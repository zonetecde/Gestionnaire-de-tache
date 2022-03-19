using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace Gestionnaire_de_tâche__Last_
{
    public class Utilities
    {
        public static string resourcesPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Zonedetec\Gestionnaire de tâche [Last]";
        public static string imagesPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Zonedetec\Gestionnaire de tâche [Last]\img\";
        public static string backupPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Zonedetec\Gestionnaire de tâche [Last]\backup\";
        public Resource resource = new Resource();

        public static bool saveWhenExit = true;
        public string linkUpdate = null;
        
        /// <summary>
        /// Initialize toutes les resources
        /// </summary>
        public void InitializeResourcesPath()
        {
          

            Directory.CreateDirectory(resourcesPath);
            Directory.CreateDirectory(imagesPath);
            Directory.CreateDirectory(backupPath);
            resourcesPath += @"\resources.zdt";

            resource.projets = new List<Projet>();

            if (!File.Exists(resourcesPath))
            {
                File.Create(resourcesPath).Close();
            }
        }

        public bool MajDispo()
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                try
                {
                    WebClient client = new WebClient();
                    string reply = client.DownloadString("https://sites.google.com/view/zonedetec/gestionnaire-de-t%C3%A2che");

                    string lastVersion = findVersionAndLink(reply, "(<strong>v", "</strong>)");

                    string actualVersion = Application.ProductVersion;

                    actualVersion = actualVersion.Remove(2, 1);
                    actualVersion = actualVersion.Remove(2, 1);

                    if (lastVersion.Equals(actualVersion))
                    {
                        return false;
                    }
                    else
                    {
                        // Lien de la mise à jour
                        linkUpdate = findVersionAndLink(reply, "<em><strong>", "</strong></em>");
                        linkUpdate = linkUpdate.Insert(0, "https://dl.dropboxusercontent.com");

                        return true;
                    }
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static string findVersionAndLink(string reply, string begin, string end)
        {
            int Start, End;
            if (reply.Contains(begin) && reply.Contains(end))
            {
                Start = reply.IndexOf(begin, 0) + begin.Length;
                End = reply.IndexOf(end, Start);
                return reply.Substring(Start, End - Start);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Charge les resources
        /// </summary>
        public void LoadResources()
        {
            string json = File.ReadAllText(resourcesPath);
            resource = JsonConvert.DeserializeObject<Resource>(json);

            if (resource == null)
            {
                resource = new Resource();
            }

            if (resource.etats.Count == 0)
            {
                Main.FirstLaunch_ = true;

                resource.etats.Add(new Etat((Color.FromName("Linen")), "Pas défini"));

                resource.etats.Add(new Etat(Color.FromArgb(128, 255, 128), "Terminer"));
                resource.etats.Add(new Etat(Color.FromName("Honeydew"), "À finir"));

                resource.etats.Add(new Etat(Color.FromArgb(255, 255, 192), "En cours"));
                resource.etats.Add(new Etat(Color.FromArgb(255, 128, 128), "Échouer"));

                resource.etats.Add(new Etat(Color.FromArgb(192, 192, 255), "En attente"));
                resource.etats.Add(new Etat((Color.FromName("RosyBrown")), "Annuler"));

                SaveResources();
            }

            if (resource.priorités.Count == 0)
            {
                Main.FirstLaunch_ = true;

                resource.priorités.Add(new Priorité((Color.FromName("Linen")), "Pas défini"));
                resource.priorités.Add(new Priorité((Color.FromName("LightCoral")), "Urgent"));

                resource.priorités.Add(new Priorité(Color.FromName("LightCyan"), "À faire"));
                resource.priorités.Add(new Priorité(Color.FromArgb(255, 255, 192), "Optionnel"));
                resource.priorités.Add(new Priorité(Color.FromName("Wheat"), "À la fin"));

                SaveResources();
            }

            if(resource.BackupInterval == 0)
            {
                resource.BackupInterval = 5;
            }
        }

        /// <summary>
        /// Sauvegarde les resources
        /// </summary>
        public void SaveResources(bool lastSave = false)
        {
            if(!lastSave)
                File.WriteAllText(resourcesPath, JsonConvert.SerializeObject(Main.Utilities.resource, Formatting.Indented));

            if (lastSave)
            {
                Main.Utilities.resource.NbDeLancementDeLappTotal++;

                File.WriteAllText(resourcesPath, JsonConvert.SerializeObject(Main.Utilities.resource, Formatting.Indented));
            }

            if (lastSave && 0 == Main.Utilities.resource.NbDeLancementDeLappTotal % Main.Utilities.resource.BackupInterval)
            {
                string filePath = backupPath + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss:mm").Replace('/', '.').Replace(':', '.') + ".backDat";

                File.Create(filePath).Close();
                File.WriteAllText(filePath, EncryptionHelper.Encrypt(File.ReadAllText(Utilities.resourcesPath)));
            }
        }

        /// <summary>
        /// De Rufus L, merci à lui - https://stackoverflow.com/questions/59617641/how-to-change-the-color-of-a-part-of-a-label-c-sharp/59617913#59617913
        /// </summary>
        /// <param name="searchText"></param>
        /// <param name="control"></param>
        public void HighlightSearchText(string searchText, RichTextBox control, Color color)
        {
            // Make all text black first (this might be optional)
            control.SelectionStart = 0;
            control.SelectionLength = control.Text.Length;

            control.SelectionColor = color;

            var selStart = control.Text.ToLower().IndexOf(searchText);
            if (selStart < 0) return;

            // Then color the search text
            control.SelectionStart = selStart;
            control.SelectionLength = searchText.Length;
            control.SelectionColor = Color.Red;
        }

        /// <summary>
        /// Package le projet en format .proj
        /// </summary>
        /// <param name="projet"></param>
        internal static void PackageProject(Projet projet, string path)
        {
            // Crée le fichier
            File.CreateText(path + @"\" + projet.Nom_du_projet + ".proj").Close();
            // Serialize le projet dedans crypter
            File.WriteAllText(path + @"\" + projet.Nom_du_projet + ".proj", EncryptionHelper.Encrypt(JsonConvert.SerializeObject(projet, Formatting.Indented)));
        }
    }
}