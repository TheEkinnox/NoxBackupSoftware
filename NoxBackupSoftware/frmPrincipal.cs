#region MÉTADONNÉES

// Nom du fichier : frmPrincipal.cs
// Auteur : Loick OBIANG (1832960)
// Date de création : 2019-08-16
// Date de modification : 2019-08-22

#endregion

#region USING

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

#endregion

namespace NoxBackupSoftware
{
    public partial class FrmPrincipal : Form
    {
        #region ATTRIBUTS

        private List<Task> _tachesEnCours;

        private Backup _backupSelect;

        private int _indexBackupSelect;

        private List<Backup> _backups;

        #endregion

        #region PROPRIÉTÉS ET INDEXEURS

        public List<Task> TachesEnCours
        {
            get { return this._tachesEnCours; }
            set { this._tachesEnCours = value; }
        }

        public Backup BackupSelect
        {
            get { return this._backupSelect; }
            set { this._backupSelect = value; }
        }

        public int IndexBackupSelect
        {
            get { return this._indexBackupSelect; }
            set { this._indexBackupSelect = value; }
        }

        public List<Backup> Backups
        {
            get { return this._backups; }
            set { this._backups = value; }
        }

        #endregion

        #region CONSTRUCTEURS

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        #endregion

        #region MÉTHODES

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                this.TachesEnCours = new List<Task>();
                ActualiserForm();

                foreach (Backup backup in this.Backups)
                {
                    this.TachesEnCours.Add(Task.Run(backup.AutoSave));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Une erreur est survenue pendant le chargement du formulaire : {exception.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BtnQuitter_Click(sender, e);
            }
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            try
            {
                Utilitaire.EnregistrerBackups(this.Backups);
                foreach (Task tache in this.TachesEnCours)
                {
                    tache.Dispose();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            finally
            {
                Dispose();
            }
        }

        private void BtnToSave_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog openFile = new CommonOpenFileDialog();
            openFile.Multiselect = true;
            openFile.Title = "Fichiers à sauvegarder";
            openFile.Filters.Add(new CommonFileDialogFilter("Tous les fichiers", "*.*"));
            //Todo: trouver comment select fichier et dossiers

            switch (openFile.ShowDialog())
            {
                case CommonFileDialogResult.Ok:
                    foreach (string fileName in openFile.FileNames)
                    {
                        this.txtToSave.Text += $";\"{fileName}\"";
                    }

                    this.txtToSave.Text = this.txtToSave.Text.Trim().Trim(new char[] {';'});
                    break;
                case CommonFileDialogResult.Cancel:
                    break;
                default:
                    break;
            }
        }

        private void BtnDestination_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog folderBrowser = new CommonOpenFileDialog();
            folderBrowser.Multiselect = false;
            folderBrowser.IsFolderPicker = true;
            switch (folderBrowser.ShowDialog())
            {
                case CommonFileDialogResult.Ok:
                    this.txtDestination.Text = folderBrowser.FileName;
                    break;
                case CommonFileDialogResult.Cancel:
                    break;
            }
        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                string nomBackup = this.txtNomSauvegarde.Text.Trim();
                if (String.IsNullOrWhiteSpace(nomBackup))
                    throw new ArgumentException("Nom de backup invalide.");
                List<string> cheminsFichiersSauvegardes = new List<string>();
                foreach (string cheminFichier in this.txtToSave.Text.Trim().Trim(new char[] {';'}).Split(';'))
                {
                    cheminsFichiersSauvegardes.Add(cheminFichier.Trim(new char[] {'"'}));
                }
                if (cheminsFichiersSauvegardes.Count < 1)
                    throw new ArgumentException("Aucun fichier/dossier à sauvegarder n'a été selectionné.");
                string destination = this.txtDestination.Text;
                int freqJ = int.Parse(this.txtFreqJour.Text.Replace("J","0"));
                int freqH = int.Parse(this.txtFreqHeure.Text.Replace("H","0"));
                int freqM = int.Parse(this.txtFreqMin.Text.Replace("M","0"));
                int freqS = int.Parse(this.txtFreqSec.Text.Replace("S","0"));
                TimeSpan frequence = new TimeSpan(freqJ, freqH, freqM, freqS);
                if (frequence.TotalSeconds < 30)
                    throw new ArgumentException("La fréquence minimum des sauvegardes est de 30 secondes.");
                List<Sauvegarde> sauvegardes = new List<Sauvegarde>();
                if (this.lstHistorique.Items.Count > 0)
                    foreach (object o in this.lstHistorique.Items)
                    {
                        Sauvegarde sauvegarde = (Sauvegarde) o;
                        sauvegardes.Add(sauvegarde);
                    }

                Backup nvBackup = new Backup(nomBackup, cheminsFichiersSauvegardes, destination, frequence.TotalSeconds, sauvegardes);
                int indexBackup = -1;
                for (int i = 0; i < this.Backups.Count; i++)
                {
                    if (this.Backups[i].Nom == nvBackup.Nom)
                    {
                        indexBackup = i;
                        break;
                    }
                }

                if (indexBackup < 0)
                    this.Backups.Add(nvBackup);
                else this.Backups[indexBackup] = nvBackup;
                Utilitaire.EnregistrerBackups(this.Backups);
                this.TachesEnCours.Add(Task.Run(nvBackup.AutoSave));
                ActualiserForm();
                this.IndexBackupSelect = this.lstSauvegardes.SelectedIndex = this.lstSauvegardes.Items.Count - 1;
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Une erreur s'est produite avec le message suivant : {exception.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSupprimerBackup_Click(object sender, EventArgs e)
        {
            this.IndexBackupSelect = this.lstSauvegardes.SelectedIndex;
            this.Backups.RemoveAt(this.IndexBackupSelect);
            Utilitaire.EnregistrerBackups(this.Backups);
            this.TachesEnCours[this.IndexBackupSelect].Dispose();
            this.TachesEnCours.RemoveAt(this.IndexBackupSelect);
            this.IndexBackupSelect = -1;
            this.BackupSelect = new Backup("",new List<string>(),"",0,new List<Sauvegarde>());
            ActualiserForm();
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            ModeEdition(true);
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            this.IndexBackupSelect = -1;
            this.BackupSelect = null;
            this.txtNomSauvegarde.Text = "";
            this.txtToSave.Text = "";
            this.txtDestination.Text = "";
            this.txtFreqJour.Text = "JJ";
            this.txtFreqHeure.Text = "HH";
            this.txtFreqMin.Text = "MM";
            this.txtFreqSec.Text = "SS";
            ModeEdition(true);
        }

        private void ActualiserInfos()
        {
            ModeEdition(false);
            this.lstHistorique.Items.Clear();
            if (this.BackupSelect == null)
                return;
            this.txtNomSauvegarde.Text = this.BackupSelect.Nom;
            this.txtToSave.Text = "";
            foreach (string cheminFichierSauvegarde in this.BackupSelect.CheminsFichiersSauvegardes)
            {
                this.txtToSave.Text += $"\"{cheminFichierSauvegarde}\";";
            }

            this.txtToSave.Text = this.txtToSave.Text.Trim().Trim(new char[] {';'});
            this.txtDestination.Text = this.BackupSelect.Destination;
            TimeSpan frequence = TimeSpan.FromSeconds(this.BackupSelect.Frequence);
            this.txtFreqJour.Text = frequence.Days.ToString();
            this.txtFreqHeure.Text = frequence.Hours.ToString();
            this.txtFreqMin.Text = frequence.Minutes.ToString();
            this.txtFreqSec.Text = frequence.Seconds.ToString();
            foreach (Sauvegarde sauvegarde in this.BackupSelect.Sauvegardes)
            {
                this.lstHistorique.Items.Add(sauvegarde);
            }
        }

        private void ActualiserBackups()
        {
            if (!Directory.Exists(Utilitaire.CheminData))
                Directory.CreateDirectory(Utilitaire.CheminData);
            if (!File.Exists(Utilitaire.CheminData + Utilitaire.BackupsFile))
            {
                Utilitaire.EnregistrerBackups(new List<Backup>());
            }

            this.Backups = Utilitaire.ChargerBackups();
            this.lstSauvegardes.Items.Clear();
            foreach (Backup backup in this.Backups)
            {
                this.lstSauvegardes.Items.Add(backup);
            }
        }

        private void ActualiserForm()
        {
            ActualiserBackups();
            ActualiserInfos();
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.IndexBackupSelect = this.lstSauvegardes.SelectedIndex;
            this.BackupSelect = (Backup) this.lstSauvegardes.SelectedItem;
            ModeEdition(false);
        }

        private void BtnOuvrir_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.BackupSelect == null)
                    throw new NullReferenceException("Aucune backup n'a été selectionnée.");
                if (this.lstHistorique.SelectedIndex < 0)
                    throw new NullReferenceException("Aucune sauvegarde n'a été selectionnée.");
                string cheminSauvegarde = this.BackupSelect.Sauvegardes[this.lstHistorique.SelectedIndex].CheminDossier;
                Process.Start($"{cheminSauvegarde}");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LstSauvegardes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.IndexBackupSelect = this.lstSauvegardes.SelectedIndex;
            this.BackupSelect = (Backup) this.lstSauvegardes.SelectedItem;
            ActualiserInfos();
        }

        private void BtnForceSauv_Click(object sender, EventArgs e)
        {
            try
            {
                Utilitaire.CreerSauvegardeAsync(this.BackupSelect).GetAwaiter().GetResult();
                this.Backups.RemoveAt(this.IndexBackupSelect);
                this.Backups.Add(this.BackupSelect);
                Utilitaire.EnregistrerBackups(this.Backups);
                ActualiserInfos();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void ModeEdition(bool edition)
        {
            this.txtNomSauvegarde.Enabled = edition;
            this.txtToSave.Enabled = edition;
            this.btnToSave.Enabled = edition;
            this.txtDestination.Enabled = edition;
            this.btnDestination.Enabled = edition;
            this.txtFreqJour.Enabled = edition;
            this.txtFreqHeure.Enabled = edition;
            this.txtFreqMin.Enabled = edition;
            this.txtFreqSec.Enabled = edition;
            this.btnEnregistrer.Enabled = edition;

        }

        #endregion

        private void BtnSupSauvegarde_Click(object sender, EventArgs e)
        {
            Directory.Delete(this.Backups[this.lstSauvegardes.SelectedIndex].Sauvegardes[this.lstHistorique.SelectedIndex].CheminDossier,true);
            this.Backups[this.lstSauvegardes.SelectedIndex].Sauvegardes.RemoveAt(this.lstHistorique.SelectedIndex);
            Utilitaire.EnregistrerBackups(this.Backups);
            ActualiserForm();
        }
    }
}