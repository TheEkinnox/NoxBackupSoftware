#region MÉTADONNÉES

// Nom du fichier : Backup.cs
// Auteur : Loick OBIANG (1832960)
// Date de création : 2019-08-18
// Date de modification : 2019-08-22

#endregion

#region USING

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

#endregion

namespace NoxBackupSoftware
{
    public class Backup
    {
        #region ATTRIBUTS

        private string _nom;
        private List<string> _cheminsFichiersSauvegardes;
        private string _destination;
        private double _frequence;
        private List<Sauvegarde> _sauvegardes;

        private Stopwatch _chrono;

        #endregion

        #region PROPRIÉTÉS ET INDEXEURS

        public string Nom
        {
            get { return this._nom; }
            set { this._nom = value; }
        }

        public List<string> CheminsFichiersSauvegardes
        {
            get { return this._cheminsFichiersSauvegardes; }
            set { this._cheminsFichiersSauvegardes = value; }
        }

        public string Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        public double Frequence
        {
            get { return this._frequence; }
            set { this._frequence = value; }
        }

        public List<Sauvegarde> Sauvegardes
        {
            get { return this._sauvegardes; }
            set { this._sauvegardes = value; }
        }

        public Stopwatch Chrono
        {
            get { return this._chrono; }
            set { this._chrono = value; }
        }

        #endregion

        #region CONSTRUCTEURS

        public Backup(string pNom, List<string> pCheminsFichiersSauvegardes, string pDestination, double pFrequence, List<Sauvegarde> pSauvegardes)
        {
            this.Nom = pNom;
            this.CheminsFichiersSauvegardes = pCheminsFichiersSauvegardes;
            this.Destination = pDestination;
            this.Frequence = pFrequence;
            this.Sauvegardes = pSauvegardes;
        }

        #endregion

        #region MÉTHODES

        public async Task AutoSave()
        {
            this.Chrono = new Stopwatch();
            AutoSaveLoop:
            try
            {
                this.Chrono.Restart();

                TimeSpan frequence = TimeSpan.FromSeconds(this.Frequence);
                Thread.Sleep(frequence);

                await Utilitaire.CreerSauvegardeAsync(this);
                goto AutoSaveLoop;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Une erreur est survenue pendant la sauvegarde avec le message suivant : {e.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override string ToString()
        {
            return this.Nom;
        }

        #endregion
    }
}