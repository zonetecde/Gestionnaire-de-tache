using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Gestionnaire_de_tâche__Last_
{
    public partial class UserControl_Projet_Vue : UserControl
    {
        internal List<string> allSousProjetWithIDSeparated = new List<string>();
        internal List<string> allTacheWithIDSeparated = new List<string>();
        internal List<string> allMotClé = new List<string>();

        public UserControl_Projet_Vue(Projet projet)
        {
            InitializeComponent();
            Projet_Associé = projet;

            if (projet != null)
            {
                setInformation(Projet_Associé);

                InitializeSearchingEngine();
            }
        }

        private void InitializeSearchingEngine()
        {
            allTacheWithIDSeparated.Clear();
            allSousProjetWithIDSeparated.Clear();
            allMotClé.Clear();

            foreach (var sousProjet in Main.selected_Projet.sous_Projets)
            {
                allSousProjetWithIDSeparated.Add(sousProjet.Nom_du_sous_projet.ToLower() + " " + sousProjet.Id_du_sous_projet);
                foreach (var tache in sousProjet.Tâches)
                {
                    allTacheWithIDSeparated.Add(tache.Nom_de_la_tâche.ToLower() + " " + tache.Id_de_la_tâche);

                    foreach (var motCle in tache.Mots_Clés)
                    {
                        allMotClé.Add(motCle);
                    }
                }
            }
        }

        public Projet Projet_Associé { get; private set; }

        private void Button_addSousProjet_MouseDown(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Edit le projet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_edit_MouseDown(object sender, MouseEventArgs e)
        {
            Ajouter_un_projet ajouter_Un_Projet = new Ajouter_un_projet(Projet_Associé);
            ajouter_Un_Projet.ShowDialog();
        }

        /// <summary>
        /// Supprime le projet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_delete_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Main main = (Main)Application.OpenForms["Main"];
                Main.projectToErase = Projet_Associé;
                Main.ifIsTheShowingProject = true;
                main.pictureBox_delete_MouseDown_1(this, new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0));
            }
        }

        /// <summary>
        /// Ajoute un sous projet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_addSousProjet_Click(object sender, EventArgs e)
        {
            if ((e as MouseEventArgs).Button == MouseButtons.Left)
            {
                Ajouter_un_sous_projet ajouter_Un_Sous_Projet = new Ajouter_un_sous_projet(Projet_Associé);
                ajouter_Un_Sous_Projet.ShowDialog();
            }
        }

        private void UserControl_Projet_Vue_Load(object sender, EventArgs e)
        {
            actualizeNbOfSousPAndTache();
        }

        internal void actualizeNbOfSousPAndTache()
        {
            int nbTâche = 0;

            foreach (var sousProjet in Projet_Associé.sous_Projets)
            {
                foreach (var tache in sousProjet.Tâches)
                {
                    nbTâche++;
                }
            }

            labelsousProjet_Count.Text = Projet_Associé.sous_Projets.Count + " sous projet(s), " + nbTâche + " tâche(s).";

            TextInfo maj = new CultureInfo("fr-Fr", false).TextInfo;

            // Informations
            if (Projet_Associé.Date_creation_du_projet != null)
            {
                labelsousProjet_Count.Text += " Crée le : " + maj.ToTitleCase(Projet_Associé.Date_creation_du_projet.ToString("D",
                CultureInfo.CreateSpecificCulture("fr-FR")));
            }

            if (Projet_Associé.Fin_du_projet != null)
            {
                string texteDateFin = "Fin prévue le : " + maj.ToTitleCase(Projet_Associé.Fin_du_projet.Value.ToString("D",
                CultureInfo.CreateSpecificCulture("fr-FR")));
                labelsousProjet_Count.Text += "\n" + texteDateFin;
            }
        }

        /// <summary>
        /// Enlève le texte dans la textbox si celui ci est égal à "Rechercher..."
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBpx_search_Enter(object sender, EventArgs e)
        {
            if (textBpx_search.text.Equals("Rechercher..."))
            {
                textBpx_search.text = string.Empty;
            }
        }

        /// <summary>
        /// Remet le texte par défault si il est null ou invalide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBpx_search_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBpx_search.text))
            {
                textBpx_search.text = "Rechercher...";
            }
        }

        /// <summary>
        /// TODO
        /// Recherche parmis toutes les tâches et les sous projets, en contant les mots clés de ceci sont cherchés
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBpx_search_OnTextChange(object sender, EventArgs e)
        {
            string toSearch = textBpx_search.text.ToLower();

            InitializeSearchingEngine();

            List<string> toShow = new List<string>();

            foreach (var motConnu in allSousProjetWithIDSeparated)
            {
                if (motConnu.Contains(toSearch))
                {
                    toShow.Add(motConnu);
                }
            }

            foreach (var motConnu in allTacheWithIDSeparated)
            {
                if (motConnu.Contains(toSearch))
                {
                    toShow.Add(motConnu);
                }
            }

            foreach (var motConnu in allMotClé)
            {
                if (motConnu.Contains(toSearch))
                {
                    toShow.Add(motConnu);
                }
            }

            Gestion_des_UserControls.ShowOnlyThis(toShow, toSearch);
        }

        /// <summary>
        /// Ouvre les statistiques
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_static_MouseDown(object sender, MouseEventArgs e)
        {
            Statistiques statistiques = new Statistiques(Projet_Associé);
            statistiques.ShowDialog();
        }

        /// <summary>
        /// Ouvre le projet visual studio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Ouvrir_VS_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    System.Diagnostics.Process.Start(Projet_Associé.Solution_path);
                }
                catch
                {
                    MessageBox.Show("Il semblerait il y avoir un problème avec le chemin d'accès de la solution :/", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Open l'éxecutable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void open_debug(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Projet_Associé.Executable_debug_path);
            }
            catch
            {
                MessageBox.Show("Il semblerait il y avoir un problème avec l'executable :/", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Actualize les info principales
        /// </summary>
        internal void setInformation(Projet Projet)
        {
            if(Projet_Associé != Projet)
            {
                Projet_Associé = Projet;
            }

            label_projectName.Text = Projet.Nom_du_projet;
            bunifuSeparator.LineColor = Color.FromArgb(Convert.ToInt32(Projet.Couleur_du_projet));
            richTextBox_desc.Text = Projet.Desc_du_projet;

            if (!String.IsNullOrEmpty(Projet.Solution_path))
            {
                Btn_Ouvrir_VS.Visible = true;
            }

            if (!(String.IsNullOrEmpty(Projet.Executable_debug_path)))
            {
                Btn_exe.Visible = true;
            }

            if (!(String.IsNullOrEmpty(Projet.Executable_release_path)))
            {
                Btn_exe.Visible = true;
            }

        }

        /// <summary>
        /// Affiche la boite de dialogue pour choisir si on lance le debug ou le release
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_exe_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button is MouseButtons.Left)
            {
                Btn_exe.ContextMenu = new ContextMenu();
                Btn_exe.ContextMenu.MenuItems.Add("Debug", open_debug);
                Btn_exe.ContextMenu.MenuItems.Add("Release", open_release);

                if (String.IsNullOrEmpty(Projet_Associé.Executable_debug_path))
                    Btn_exe.ContextMenu.MenuItems[0].Enabled = false;

                if (String.IsNullOrEmpty(Projet_Associé.Executable_release_path))
                    Btn_exe.ContextMenu.MenuItems[1].Enabled = false;

                Btn_exe.ContextMenu.Show(Btn_exe, new Point(e.X, e.Y));
            }
        }

        /// <summary>
        /// Open l'éxecutable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void open_release(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Projet_Associé.Executable_release_path);
            }
            catch
            {
                MessageBox.Show("Il semblerait il y avoir un problème avec l'executable :/", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Ouvre la fenetre pour l'ordre des tâches/sous projets
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_order_MouseDown(object sender, MouseEventArgs e)
        {
            Ordre ordre_win = new Ordre(Projet_Associé);
            ordre_win.ShowDialog();
        }

        /// <summary>
        /// Exporte au formar .prj
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_exporte_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button is MouseButtons.Left)
            {
                pictureBox_exporte.ContextMenu = new ContextMenu();
                pictureBox_exporte.ContextMenu.MenuItems.Add("Enregistrer (*.proj)", exporte_Enregistrer);
                pictureBox_exporte.ContextMenu.MenuItems.Add("Exporter tableau Excel (*.xls)", exporte_Excel);
                pictureBox_exporte.ContextMenu.Show(pictureBox_exporte, new Point(e.X, e.Y));
            }
        }

        /// <summary>
        /// Enregistre le projet en proj
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exporte_Enregistrer(object sender, EventArgs e)
        {
            OpenFileDialog folderBrowser = new OpenFileDialog();
            // Set validate names and check file exists to false otherwise windows will
            // not let you select "Folder Selection."
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            // Always default to Folder Selection.
            folderBrowser.FileName = "Séléctionner un dossier";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                Utilities.PackageProject(Projet_Associé, Path.GetDirectoryName(folderBrowser.FileName));
            }
        }

        /// <summary>
        /// Exporte au format excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exporte_Excel(object sender, EventArgs e)
        {
            OpenFileDialog folderBrowser = new OpenFileDialog();
            // Set validate names and check file exists to false otherwise windows will
            // not let you select "Folder Selection."
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            // Always default to Folder Selection.
            folderBrowser.FileName = "Séléctionner un dossier";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                Project_to_Excel.createExcelFile(Path.GetDirectoryName(folderBrowser.FileName), Projet_Associé);
            }
        }

        /// <summary>
        /// Colle le sous projet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void collerLeSousProjetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Projet_Associé.sous_Projets.Insert(0, toPaste);
            Gestion_des_UserControls.AddSousProjetInPanel(toPaste);
        }


        /// <summary>
        /// Active / Désactive la fonction pour coller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        Sous_Projet toPaste;
        private void contextMenuStrip_options_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {           
            try
            {
                string json = EncryptionHelper.Decrypt(Clipboard.GetText());
                toPaste = JsonConvert.DeserializeObject<Sous_Projet>(json);

                if (toPaste.Id_du_sous_projet != 0 || !string.IsNullOrEmpty(toPaste.Nom_du_sous_projet))
                {
                    Random rdn = new Random();
                    toPaste.Id_du_sous_projet = rdn.Next(0, 275694879);

                    contextMenuStrip_options.Items[0].Enabled = true;
                }
                else
                {
                    contextMenuStrip_options.Items[0].Enabled = false;
                }
            }
            catch
            {
                contextMenuStrip_options.Items[0].Enabled = false;
            }        
        }
    }
}