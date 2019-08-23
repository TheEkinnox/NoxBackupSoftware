#region MÉTADONNÉES

// Nom du fichier : Sauvegarde.cs
// Auteur : Loick OBIANG (1832960)
// Date de création : 2019-08-18
// Date de modification : 2019-08-18

#endregion

namespace NoxBackupSoftware
{
    public class Sauvegarde
    {
        #region ATTRIBUTS

        private string _nom;
        private string _cheminDossier;

        #endregion

        #region PROPRIÉTÉS ET INDEXEURS

        public string Nom
        {
            get { return this._nom; }
            set { this._nom = value; }
        }

        public string CheminDossier
        {
            get { return this._cheminDossier; }
            set { this._cheminDossier = value; }
        }

        public Sauvegarde(string pNom, string pCheminDossier)
        {
            this.Nom = pNom;
            this.CheminDossier = pCheminDossier;
        }
        public override string ToString()
        {
            return this.Nom;
        }
        #endregion
    }
}