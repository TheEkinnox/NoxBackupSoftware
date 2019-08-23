namespace NoxBackupSoftware
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.grpSauvegardes = new System.Windows.Forms.GroupBox();
            this.btnSupprimerBackup = new System.Windows.Forms.Button();
            this.lstSauvegardes = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpInfos = new System.Windows.Forms.GroupBox();
            this.grpHistoriques = new System.Windows.Forms.GroupBox();
            this.lstHistorique = new System.Windows.Forms.ListBox();
            this.btnForceSauv = new System.Windows.Forms.Button();
            this.btnSupSauvegarde = new System.Windows.Forms.Button();
            this.btnOuvrir = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.txtFreqSec = new System.Windows.Forms.TextBox();
            this.txtFreqMin = new System.Windows.Forms.TextBox();
            this.lblMinSec = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblJourHeures = new System.Windows.Forms.Label();
            this.lblHeuresMin = new System.Windows.Forms.Label();
            this.txtFreqJour = new System.Windows.Forms.TextBox();
            this.txtFreqHeure = new System.Windows.Forms.TextBox();
            this.lblFrequence = new System.Windows.Forms.Label();
            this.btnDestination = new System.Windows.Forms.Button();
            this.btnToSave = new System.Windows.Forms.Button();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.txtToSave = new System.Windows.Forms.TextBox();
            this.lblToSave = new System.Windows.Forms.Label();
            this.txtNomSauvegarde = new System.Windows.Forms.TextBox();
            this.lblNomSauvegarde = new System.Windows.Forms.Label();
            this.grpSauvegardes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpInfos.SuspendLayout();
            this.grpHistoriques.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAjouter.Location = new System.Drawing.Point(9, 502);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(115, 28);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifier.Location = new System.Drawing.Point(131, 502);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(115, 28);
            this.btnModifier.TabIndex = 4;
            this.btnModifier.Text = "Modifer";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // grpSauvegardes
            // 
            this.grpSauvegardes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpSauvegardes.Controls.Add(this.btnSupprimerBackup);
            this.grpSauvegardes.Controls.Add(this.lstSauvegardes);
            this.grpSauvegardes.Controls.Add(this.btnModifier);
            this.grpSauvegardes.Controls.Add(this.btnAjouter);
            this.grpSauvegardes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSauvegardes.Location = new System.Drawing.Point(0, 0);
            this.grpSauvegardes.Margin = new System.Windows.Forms.Padding(4);
            this.grpSauvegardes.Name = "grpSauvegardes";
            this.grpSauvegardes.Padding = new System.Windows.Forms.Padding(4);
            this.grpSauvegardes.Size = new System.Drawing.Size(377, 543);
            this.grpSauvegardes.TabIndex = 1;
            this.grpSauvegardes.TabStop = false;
            this.grpSauvegardes.Text = "Mes _backups";
            // 
            // btnSupprimerBackup
            // 
            this.btnSupprimerBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimerBackup.Location = new System.Drawing.Point(253, 502);
            this.btnSupprimerBackup.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimerBackup.Name = "btnSupprimerBackup";
            this.btnSupprimerBackup.Size = new System.Drawing.Size(115, 28);
            this.btnSupprimerBackup.TabIndex = 5;
            this.btnSupprimerBackup.Text = "Supprimer";
            this.btnSupprimerBackup.UseVisualStyleBackColor = true;
            this.btnSupprimerBackup.Click += new System.EventHandler(this.BtnSupprimerBackup_Click);
            // 
            // lstSauvegardes
            // 
            this.lstSauvegardes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSauvegardes.FormattingEnabled = true;
            this.lstSauvegardes.ItemHeight = 16;
            this.lstSauvegardes.Location = new System.Drawing.Point(10, 27);
            this.lstSauvegardes.Margin = new System.Windows.Forms.Padding(4);
            this.lstSauvegardes.Name = "lstSauvegardes";
            this.lstSauvegardes.Size = new System.Drawing.Size(359, 468);
            this.lstSauvegardes.TabIndex = 2;
            this.lstSauvegardes.SelectedIndexChanged += new System.EventHandler(this.LstSauvegardes_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.MinimumSize = new System.Drawing.Size(1045, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpSauvegardes);
            this.splitContainer1.Panel1MinSize = 377;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpInfos);
            this.splitContainer1.Panel2MinSize = 386;
            this.splitContainer1.Size = new System.Drawing.Size(1045, 543);
            this.splitContainer1.SplitterDistance = 377;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // grpInfos
            // 
            this.grpInfos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInfos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpInfos.Controls.Add(this.grpHistoriques);
            this.grpInfos.Controls.Add(this.btnEnregistrer);
            this.grpInfos.Controls.Add(this.txtFreqSec);
            this.grpInfos.Controls.Add(this.txtFreqMin);
            this.grpInfos.Controls.Add(this.lblMinSec);
            this.grpInfos.Controls.Add(this.btnAnnuler);
            this.grpInfos.Controls.Add(this.btnQuitter);
            this.grpInfos.Controls.Add(this.lblJourHeures);
            this.grpInfos.Controls.Add(this.lblHeuresMin);
            this.grpInfos.Controls.Add(this.txtFreqJour);
            this.grpInfos.Controls.Add(this.txtFreqHeure);
            this.grpInfos.Controls.Add(this.lblFrequence);
            this.grpInfos.Controls.Add(this.btnDestination);
            this.grpInfos.Controls.Add(this.btnToSave);
            this.grpInfos.Controls.Add(this.txtDestination);
            this.grpInfos.Controls.Add(this.lblDestination);
            this.grpInfos.Controls.Add(this.txtToSave);
            this.grpInfos.Controls.Add(this.lblToSave);
            this.grpInfos.Controls.Add(this.txtNomSauvegarde);
            this.grpInfos.Controls.Add(this.lblNomSauvegarde);
            this.grpInfos.Location = new System.Drawing.Point(0, 0);
            this.grpInfos.Margin = new System.Windows.Forms.Padding(4);
            this.grpInfos.Name = "grpInfos";
            this.grpInfos.Padding = new System.Windows.Forms.Padding(4);
            this.grpInfos.Size = new System.Drawing.Size(663, 543);
            this.grpInfos.TabIndex = 0;
            this.grpInfos.TabStop = false;
            this.grpInfos.Text = "Informations de la backup";
            // 
            // grpHistoriques
            // 
            this.grpHistoriques.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpHistoriques.Controls.Add(this.lstHistorique);
            this.grpHistoriques.Controls.Add(this.btnForceSauv);
            this.grpHistoriques.Controls.Add(this.btnSupSauvegarde);
            this.grpHistoriques.Controls.Add(this.btnOuvrir);
            this.grpHistoriques.Location = new System.Drawing.Point(7, 148);
            this.grpHistoriques.Name = "grpHistoriques";
            this.grpHistoriques.Size = new System.Drawing.Size(656, 348);
            this.grpHistoriques.TabIndex = 17;
            this.grpHistoriques.TabStop = false;
            this.grpHistoriques.Text = "Historique des sauvegardes";
            // 
            // lstHistorique
            // 
            this.lstHistorique.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstHistorique.FormattingEnabled = true;
            this.lstHistorique.ItemHeight = 16;
            this.lstHistorique.Location = new System.Drawing.Point(6, 21);
            this.lstHistorique.Name = "lstHistorique";
            this.lstHistorique.Size = new System.Drawing.Size(520, 324);
            this.lstHistorique.TabIndex = 18;
            // 
            // btnForceSauv
            // 
            this.btnForceSauv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnForceSauv.Location = new System.Drawing.Point(533, 94);
            this.btnForceSauv.Margin = new System.Windows.Forms.Padding(4);
            this.btnForceSauv.Name = "btnForceSauv";
            this.btnForceSauv.Size = new System.Drawing.Size(115, 28);
            this.btnForceSauv.TabIndex = 20;
            this.btnForceSauv.Text = "Forcer sauv.";
            this.btnForceSauv.UseVisualStyleBackColor = true;
            this.btnForceSauv.Click += new System.EventHandler(this.BtnForceSauv_Click);
            // 
            // btnSupSauvegarde
            // 
            this.btnSupSauvegarde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupSauvegarde.Location = new System.Drawing.Point(533, 58);
            this.btnSupSauvegarde.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupSauvegarde.Name = "btnSupSauvegarde";
            this.btnSupSauvegarde.Size = new System.Drawing.Size(115, 28);
            this.btnSupSauvegarde.TabIndex = 20;
            this.btnSupSauvegarde.Text = "Supprimer";
            this.btnSupSauvegarde.UseVisualStyleBackColor = true;
            this.btnSupSauvegarde.Click += new System.EventHandler(this.BtnSupSauvegarde_Click);
            // 
            // btnOuvrir
            // 
            this.btnOuvrir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOuvrir.Location = new System.Drawing.Point(533, 22);
            this.btnOuvrir.Margin = new System.Windows.Forms.Padding(4);
            this.btnOuvrir.Name = "btnOuvrir";
            this.btnOuvrir.Size = new System.Drawing.Size(115, 28);
            this.btnOuvrir.TabIndex = 19;
            this.btnOuvrir.Text = "Ouvrir";
            this.btnOuvrir.UseVisualStyleBackColor = true;
            this.btnOuvrir.Click += new System.EventHandler(this.BtnOuvrir_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnregistrer.Enabled = false;
            this.btnEnregistrer.Location = new System.Drawing.Point(295, 502);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(115, 28);
            this.btnEnregistrer.TabIndex = 21;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.BtnEnregistrer_Click);
            // 
            // txtFreqSec
            // 
            this.txtFreqSec.Enabled = false;
            this.txtFreqSec.Location = new System.Drawing.Point(340, 118);
            this.txtFreqSec.Margin = new System.Windows.Forms.Padding(4);
            this.txtFreqSec.Name = "txtFreqSec";
            this.txtFreqSec.Size = new System.Drawing.Size(29, 22);
            this.txtFreqSec.TabIndex = 16;
            this.txtFreqSec.Text = "SS";
            this.txtFreqSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFreqMin
            // 
            this.txtFreqMin.Enabled = false;
            this.txtFreqMin.Location = new System.Drawing.Point(292, 118);
            this.txtFreqMin.Margin = new System.Windows.Forms.Padding(4);
            this.txtFreqMin.Name = "txtFreqMin";
            this.txtFreqMin.Size = new System.Drawing.Size(29, 22);
            this.txtFreqMin.TabIndex = 14;
            this.txtFreqMin.Text = "MM";
            this.txtFreqMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMinSec
            // 
            this.lblMinSec.AutoSize = true;
            this.lblMinSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinSec.Location = new System.Drawing.Point(325, 119);
            this.lblMinSec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinSec.Name = "lblMinSec";
            this.lblMinSec.Size = new System.Drawing.Size(11, 16);
            this.lblMinSec.TabIndex = 15;
            this.lblMinSec.Text = ":";
            this.lblMinSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnuler.Location = new System.Drawing.Point(418, 502);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(115, 28);
            this.btnAnnuler.TabIndex = 22;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitter.Location = new System.Drawing.Point(540, 502);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(115, 28);
            this.btnQuitter.TabIndex = 23;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // lblJourHeures
            // 
            this.lblJourHeures.AutoSize = true;
            this.lblJourHeures.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJourHeures.Location = new System.Drawing.Point(229, 119);
            this.lblJourHeures.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJourHeures.Name = "lblJourHeures";
            this.lblJourHeures.Size = new System.Drawing.Size(11, 16);
            this.lblJourHeures.TabIndex = 11;
            this.lblJourHeures.Text = ":";
            this.lblJourHeures.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeuresMin
            // 
            this.lblHeuresMin.AutoSize = true;
            this.lblHeuresMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeuresMin.Location = new System.Drawing.Point(277, 119);
            this.lblHeuresMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeuresMin.Name = "lblHeuresMin";
            this.lblHeuresMin.Size = new System.Drawing.Size(11, 16);
            this.lblHeuresMin.TabIndex = 13;
            this.lblHeuresMin.Text = ":";
            this.lblHeuresMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFreqJour
            // 
            this.txtFreqJour.Enabled = false;
            this.txtFreqJour.Location = new System.Drawing.Point(196, 118);
            this.txtFreqJour.Margin = new System.Windows.Forms.Padding(4);
            this.txtFreqJour.Name = "txtFreqJour";
            this.txtFreqJour.Size = new System.Drawing.Size(29, 22);
            this.txtFreqJour.TabIndex = 10;
            this.txtFreqJour.Text = "JJ";
            this.txtFreqJour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFreqHeure
            // 
            this.txtFreqHeure.Enabled = false;
            this.txtFreqHeure.Location = new System.Drawing.Point(244, 118);
            this.txtFreqHeure.Margin = new System.Windows.Forms.Padding(4);
            this.txtFreqHeure.Name = "txtFreqHeure";
            this.txtFreqHeure.Size = new System.Drawing.Size(29, 22);
            this.txtFreqHeure.TabIndex = 12;
            this.txtFreqHeure.Text = "HH";
            this.txtFreqHeure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFrequence
            // 
            this.lblFrequence.AutoSize = true;
            this.lblFrequence.Location = new System.Drawing.Point(14, 121);
            this.lblFrequence.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrequence.Name = "lblFrequence";
            this.lblFrequence.Size = new System.Drawing.Size(174, 16);
            this.lblFrequence.TabIndex = 9;
            this.lblFrequence.Text = "Fréquence de sauvegarde :";
            // 
            // btnDestination
            // 
            this.btnDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDestination.Enabled = false;
            this.btnDestination.Image = global::NoxBackupSoftware.Properties.Resources.select_folder;
            this.btnDestination.Location = new System.Drawing.Point(631, 86);
            this.btnDestination.Margin = new System.Windows.Forms.Padding(4);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(24, 24);
            this.btnDestination.TabIndex = 8;
            this.btnDestination.UseVisualStyleBackColor = true;
            this.btnDestination.Click += new System.EventHandler(this.BtnDestination_Click);
            // 
            // btnToSave
            // 
            this.btnToSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToSave.Enabled = false;
            this.btnToSave.Image = global::NoxBackupSoftware.Properties.Resources.select_folder;
            this.btnToSave.Location = new System.Drawing.Point(631, 52);
            this.btnToSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnToSave.Name = "btnToSave";
            this.btnToSave.Size = new System.Drawing.Size(24, 24);
            this.btnToSave.TabIndex = 5;
            this.btnToSave.UseVisualStyleBackColor = true;
            this.btnToSave.Click += new System.EventHandler(this.BtnToSave_Click);
            // 
            // txtDestination
            // 
            this.txtDestination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestination.Enabled = false;
            this.txtDestination.Location = new System.Drawing.Point(196, 86);
            this.txtDestination.Margin = new System.Windows.Forms.Padding(4);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(427, 22);
            this.txtDestination.TabIndex = 7;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(20, 89);
            this.lblDestination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(168, 16);
            this.lblDestination.TabIndex = 6;
            this.lblDestination.Text = "Destination de sauvgarde :";
            // 
            // txtToSave
            // 
            this.txtToSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToSave.Enabled = false;
            this.txtToSave.Location = new System.Drawing.Point(196, 54);
            this.txtToSave.Margin = new System.Windows.Forms.Padding(4);
            this.txtToSave.Name = "txtToSave";
            this.txtToSave.Size = new System.Drawing.Size(427, 22);
            this.txtToSave.TabIndex = 4;
            // 
            // lblToSave
            // 
            this.lblToSave.AutoSize = true;
            this.lblToSave.Location = new System.Drawing.Point(28, 56);
            this.lblToSave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToSave.Name = "lblToSave";
            this.lblToSave.Size = new System.Drawing.Size(160, 16);
            this.lblToSave.TabIndex = 3;
            this.lblToSave.Text = "Fichier(s) à sauvegarder :";
            // 
            // txtNomSauvegarde
            // 
            this.txtNomSauvegarde.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomSauvegarde.Enabled = false;
            this.txtNomSauvegarde.Location = new System.Drawing.Point(196, 22);
            this.txtNomSauvegarde.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomSauvegarde.Name = "txtNomSauvegarde";
            this.txtNomSauvegarde.Size = new System.Drawing.Size(459, 22);
            this.txtNomSauvegarde.TabIndex = 2;
            // 
            // lblNomSauvegarde
            // 
            this.lblNomSauvegarde.AutoSize = true;
            this.lblNomSauvegarde.Location = new System.Drawing.Point(36, 25);
            this.lblNomSauvegarde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomSauvegarde.Name = "lblNomSauvegarde";
            this.lblNomSauvegarde.Size = new System.Drawing.Size(152, 16);
            this.lblNomSauvegarde.TabIndex = 1;
            this.lblNomSauvegarde.Text = "Nom de la sauvegarde :";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 543);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1061, 582);
            this.Name = "FrmPrincipal";
            this.Text = "Nox Backup Software";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.grpSauvegardes.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpInfos.ResumeLayout(false);
            this.grpInfos.PerformLayout();
            this.grpHistoriques.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.GroupBox grpSauvegardes;
        private System.Windows.Forms.Button btnSupprimerBackup;
        private System.Windows.Forms.ListBox lstSauvegardes;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpInfos;
        private System.Windows.Forms.Label lblNomSauvegarde;
        private System.Windows.Forms.TextBox txtNomSauvegarde;
        private System.Windows.Forms.Label lblToSave;
        private System.Windows.Forms.TextBox txtToSave;
        private System.Windows.Forms.Button btnToSave;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox txtFreqHeure;
        private System.Windows.Forms.Label lblFrequence;
        private System.Windows.Forms.TextBox txtFreqMin;
        private System.Windows.Forms.Label lblHeuresMin;
        private System.Windows.Forms.Label lblMinSec;
        private System.Windows.Forms.TextBox txtFreqSec;
        private System.Windows.Forms.Label lblJourHeures;
        private System.Windows.Forms.TextBox txtFreqJour;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnOuvrir;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.ListBox lstHistorique;
        private System.Windows.Forms.GroupBox grpHistoriques;
        private System.Windows.Forms.Button btnSupSauvegarde;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnForceSauv;
    }
}

