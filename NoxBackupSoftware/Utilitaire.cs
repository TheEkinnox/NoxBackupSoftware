#region MÉTADONNÉES

// Nom du fichier : Utilitaire.cs
// Auteur : Loick OBIANG (1832960)
// Date de création : 2019-08-18
// Date de modification : 2019-08-23

#endregion

#region USING

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml;

#endregion

namespace NoxBackupSoftware
{
    public class Utilitaire
    {
        #region CONSTANTES ET ATTRIBUTS STATIQUES

        public static string CheminData = Assembly.GetEntryAssembly()?.Location.Replace("NoxBackupSoftware.exe", @"Data\");
        public static string BackupsFile = "backups.dll";

        #endregion

        #region MÉTHODES

        /// <summary>
        /// Méthode qui permet de charger un fichier XML.
        /// </summary>
        /// <param name="cheminFichier">Chemin du fichier XML</param>
        private static XmlDocument ChargerFichierXml(string cheminFichier)
        {
            if (cheminFichier == null)
                throw new ArgumentNullException(null, "Fichier inexistant");
            else if (!File.Exists(cheminFichier))
                throw new ArgumentException("Fichier XML introuvable");

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(cheminFichier);
            return xmlDoc;
        }

        public static List<Backup> ChargerBackups()
        {
            List<Backup> backups = new List<Backup>();
            try
            {
                XmlDocument xmlDoc = Utilitaire.ChargerFichierXml(Utilitaire.CheminData + Utilitaire.BackupsFile);

                XmlNodeList listeElemBackup = xmlDoc.GetElementsByTagName("backup");

                string nom;
                List<string> cheminsFichiersSauvegardes;
                string destination;
                float frequence;
                List<Sauvegarde> sauvegardes;

                foreach (XmlElement elemBackup in listeElemBackup)
                {
                    nom = elemBackup.GetElementsByTagName("nom")[0].InnerText;
                    cheminsFichiersSauvegardes = new List<string>();
                    XmlNodeList listeElemFichierSauvegarde = ((XmlElement) elemBackup.GetElementsByTagName("cheminsFichiersSauvegardes")[0]).GetElementsByTagName("cheminFichierSauvegarde");
                    for (int i = 0; i < listeElemFichierSauvegarde.Count; i++)
                    {
                        XmlElement elemFichierSauvegarde = (XmlElement) listeElemFichierSauvegarde.Item(i);
                        if (elemFichierSauvegarde == null)
                            throw new ArgumentNullException(null, "Fichier sauvegardé manquant dans le fichier XML.");
                        cheminsFichiersSauvegardes.Add(elemFichierSauvegarde.InnerText);
                    }

                    destination = elemBackup.GetElementsByTagName("destination")[0].InnerText;
                    frequence = float.Parse(elemBackup.GetElementsByTagName("frequence")[0].InnerText);

                    sauvegardes = new List<Sauvegarde>();
                    XmlNodeList listeElemSauvegarde = ((XmlElement) elemBackup.GetElementsByTagName("sauvegardes")[0]).GetElementsByTagName("sauvegarde");
                    for (int i = 0; i < listeElemSauvegarde.Count; i++)
                    {
                        XmlElement elemSauvegarde = (XmlElement) listeElemSauvegarde.Item(i);
                        if (elemSauvegarde == null)
                            throw new ArgumentNullException(null, "Sauvegarde manquante dans le fichier XML.");

                        string nomSauvegarde = elemSauvegarde.GetElementsByTagName("nom")[0].InnerText;
                        string dossierSauvegarde = elemBackup.GetElementsByTagName("dossier")[0].InnerText;
                        if (Directory.Exists(dossierSauvegarde))
                            sauvegardes.Add(new Sauvegarde(nomSauvegarde, dossierSauvegarde));
                    }

                    backups.Add(new Backup(nom, cheminsFichiersSauvegardes, destination, frequence, sauvegardes));
                }

                Utilitaire.EnregistrerBackups(backups);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return backups;
        }

        public static bool EnregistrerBackups(List<Backup> backups)
        {
            try
            {
                FileStream fileStream = new FileStream(Utilitaire.CheminData + Utilitaire.BackupsFile, FileMode.OpenOrCreate);
                fileStream.Close();
                XmlDocument backupsXml = new XmlDocument();
                XmlDeclaration xmlDeclaration = backupsXml.CreateXmlDeclaration("1.0", "utf-8", null);
                backupsXml.AppendChild(xmlDeclaration);

                XmlElement root = backupsXml.CreateElement("backups");
                foreach (Backup backup in backups)
                {
                    XmlElement elemBackup = backupsXml.CreateElement("backup");
                    XmlElement nom, cheminsFichiersSauvegarde, destination, frequence, sauvegardes;

                    nom = backupsXml.CreateElement("nom");
                    nom.InnerText = backup.Nom;
                    elemBackup.AppendChild(nom);
                    cheminsFichiersSauvegarde = backupsXml.CreateElement("cheminsFichiersSauvegardes");
                    foreach (string fichierSauvegarde in backup.CheminsFichiersSauvegardes)
                    {
                        XmlElement cheminFichierSauvegarde = backupsXml.CreateElement("cheminFichierSauvegarde");
                        cheminFichierSauvegarde.InnerText = fichierSauvegarde;
                        cheminsFichiersSauvegarde.AppendChild(cheminFichierSauvegarde);
                    }

                    elemBackup.AppendChild(cheminsFichiersSauvegarde);
                    destination = backupsXml.CreateElement("destination");
                    destination.InnerText = backup.Destination;
                    elemBackup.AppendChild(destination);
                    frequence = backupsXml.CreateElement("frequence");
                    frequence.InnerText = backup.Frequence.ToString();
                    elemBackup.AppendChild(frequence);
                    sauvegardes = backupsXml.CreateElement("sauvegardes");
                    foreach (Sauvegarde sauvegarde in backup.Sauvegardes)
                    {
                        XmlElement elemSauvegarde = backupsXml.CreateElement("sauvegarde");
                        XmlElement nomSauvegarde, cheminDossier;
                        nomSauvegarde = backupsXml.CreateElement("nom");
                        nomSauvegarde.InnerText = sauvegarde.Nom;
                        elemSauvegarde.AppendChild(nomSauvegarde);
                        cheminDossier = backupsXml.CreateElement("dossier");
                        cheminDossier.InnerText = sauvegarde.CheminDossier;
                        elemSauvegarde.AppendChild(cheminDossier);
                        sauvegardes.AppendChild(elemSauvegarde);
                    }

                    elemBackup.AppendChild(sauvegardes);
                    root.AppendChild(elemBackup);
                }

                backupsXml.AppendChild(root);
                backupsXml.Save(Utilitaire.CheminData + Utilitaire.BackupsFile);

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public static async Task CreerSauvegardeAsync(Backup backup)
        {
            if (backup.Destination == null)
                throw new ArgumentNullException(null, "Aucune destination n'a été entrée.");
            else if (!Directory.Exists(backup.Destination))
                Directory.CreateDirectory(backup.Destination);

            bool dossier = false;

            foreach (string cheminFichier in backup.CheminsFichiersSauvegardes)
            {
                if (cheminFichier == null)
                    throw new ArgumentNullException(null, "Fichier à copier manquant.");
                else if (!File.Exists(cheminFichier))
                    if (!Directory.Exists(cheminFichier))
                        throw new FileNotFoundException("Le fichier à copier n'a pas été trouvé.");
                    else
                        dossier = true;
                string nomSauvegarde = $"{backup.Nom}-{DateTime.Now.Year:0000}{DateTime.Now.Month:00}{DateTime.Now.Day:00}-" +
                                       $"{DateTime.Now.Hour:00}{DateTime.Now.Minute:00}{DateTime.Now.Second:00}";
                string nomFichier = cheminFichier.Substring(cheminFichier.LastIndexOf('\\') + 1);
                if (!Directory.Exists(backup.Destination + $"\\{nomSauvegarde}"))
                    Directory.CreateDirectory(backup.Destination + $"\\{nomSauvegarde}");
                if (!dossier)
                    File.Copy(cheminFichier,
                        backup.Destination + $"\\{nomSauvegarde}\\{nomFichier}",
                        File.Exists(backup.Destination + $"\\{nomSauvegarde}\\{nomFichier}"));
                else
                    Utilitaire.Xcopy(cheminFichier,
                        backup.Destination + $"\\{nomSauvegarde}\\{nomFichier}");

                backup.Sauvegardes.Add(new Sauvegarde(nomSauvegarde, backup.Destination + $"\\{nomSauvegarde}"));
            }
        }

        private static void Xcopy(string solutionDirectory, string targetDirectory)

        {
            // Use ProcessStartInfo class

            ProcessStartInfo startInfo = new ProcessStartInfo();

            startInfo.CreateNoWindow = false;

            startInfo.UseShellExecute = false;

            //Give the name as Xcopy

            startInfo.FileName = "xcopy";

            //make the window Hidden

            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;

            //Send the Source and destination as Arguments to the process

            startInfo.Arguments = "\"" + solutionDirectory + "\"" + " " + "\"" + targetDirectory + "\"" + @" /e /y /I";

            // Start the process with the info we specified.

            // Call WaitForExit and then the using statement will close.

            using (Process exeProcess = Process.Start(startInfo))
            {
                if (exeProcess != null) exeProcess.WaitForExit();
            }
        }

        #endregion
    }
}