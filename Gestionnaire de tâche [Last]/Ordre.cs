using System;
using System.Windows.Forms;

namespace Gestionnaire_de_tâche__Last_
{
    public partial class Ordre : Form
    {
        public Projet Projet { get; }

        public Ordre(Projet projet)
        {
            InitializeComponent();

            this.Icon = Gestionnaire_de_tâche__Last_.Properties.Resources.icon_ordre;
            Projet = projet;

            addAllSousProjectInListBoxAndComboList(true);
        }

        // SOUS PROJET
        #region

        internal void addAllSousProjectInListBoxAndComboList(bool erase, string selectedSP = null)
        {
            pictureBox_down.Visible = false;
            pictureBox_up.Visible = false;
            label_monter.Visible = false;
            label_descendre.Visible = false;

            if (erase)
            {
                listBox_sousProjet.Items.Clear();
                comboBox_sousProjet.Items.Clear();
            }

            foreach (var sousProjet in Projet.sous_Projets)
            {
                listBox_sousProjet.Items.Add(sousProjet.Nom_du_sous_projet);
                comboBox_sousProjet.Items.Add(sousProjet.Nom_du_sous_projet);

                pictureBox_trash.Visible = true;
            }

            if (listBox_sousProjet.Items.Count != 0)
            {
                listBox_sousProjet.SelectedIndex = 0;

                pictureBox_up.Visible = false;
                label_monter.Visible = false;
            }

            if (comboBox_sousProjet.Items.Count != 0)
            {
                comboBox_sousProjet.SelectedIndex = 0;
            }

            if (selectedSP != null)
            {
                listBox_sousProjet.SelectedItem = selectedSP;
            }

            if (listBox_sousProjet.Items.Count == 0)
            {
                pictureBox_trash.Visible = false;
            }
        }

        private void Ordre_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Monte d'un cran l'élément séléctionner dans la listBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_monter_MouseDown(object sender, MouseEventArgs e)
        {
            modify = true;
            string selectedSP = Projet.sous_Projets[listBox_sousProjet.SelectedIndex].Nom_du_sous_projet;

            ListExtensions.Move(Projet.sous_Projets, listBox_sousProjet.SelectedIndex, MoveDirection.Up);

            addAllSousProjectInListBoxAndComboList(true, selectedSP);

            if (listBox_sousProjet.SelectedIndex == 0)
            {
                pictureBox_up.Visible = false;
                label_monter.Visible = false;
                pictureBox_down.Visible = true;
                label_descendre.Visible = true;
            }
            else
            {
                pictureBox_up.Visible = true;
                label_monter.Visible = true;
                pictureBox_down.Visible = true;
                label_descendre.Visible = true;
            }
        }

        /// <summary>
        /// Descend d'un cran l'élément séléctionner dans la listBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_down_MouseDown(object sender, MouseEventArgs e)
        {
            modify = true;

            string selectedSP = Projet.sous_Projets[listBox_sousProjet.SelectedIndex].Nom_du_sous_projet;

            ListExtensions.Move(Projet.sous_Projets, listBox_sousProjet.SelectedIndex, MoveDirection.Down);

            addAllSousProjectInListBoxAndComboList(true, selectedSP);

            if (listBox_sousProjet.SelectedIndex == listBox_sousProjet.Items.Count - 1)
            {
                pictureBox_up.Visible = true;
                label_monter.Visible = true;
                pictureBox_down.Visible = false;
                label_descendre.Visible = false;
            }
            else
            {
                pictureBox_up.Visible = true;
                label_monter.Visible = true;
                pictureBox_down.Visible = true;
                label_descendre.Visible = true;
            }
        }

        /// <summary>
        /// Montre/Cache les flèches pour monter descendre si on est au extremiter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_sousProjet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_sousProjet.SelectedIndex == listBox_sousProjet.Items.Count - 1)
            {
                pictureBox_up.Visible = true;
                label_monter.Visible = true;
                pictureBox_down.Visible = false;
                label_descendre.Visible = false;
            }
            else if (listBox_sousProjet.SelectedIndex == 0)
            {
                pictureBox_up.Visible = false;
                label_monter.Visible = false;
                pictureBox_down.Visible = true;
                label_descendre.Visible = true;
            }
            else
            {
                pictureBox_up.Visible = true;
                label_monter.Visible = true;
                pictureBox_down.Visible = true;
                label_descendre.Visible = true;
            }

            if (listBox_sousProjet.Items.Count <= 1)
            {
                pictureBox_descendreTache.Visible = false;
                pictureBox_monterTache.Visible = false;
                label_monterTache.Visible = false;
                label_descendreTache.Visible = false;
            }
        }

        private void Ordre_FormClosed(object sender, FormClosedEventArgs e)
        {
            Gestion_des_UserControls.ActualizeNbOfSousProjetAndTache();

            if(modify)
                Gestion_des_UserControls.LoadAllSousProjetFor(Projet);

            Main.Utilities.SaveResources();
        }

        /// <summary>
        /// Supprime le sousProjet séléctioné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_trash_MouseDown(object sender, MouseEventArgs e)
        {
            modify = true;

            DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer " + Projet.sous_Projets[listBox_sousProjet.SelectedIndex].Nom_du_sous_projet + " ?", "Sûre ?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Projet.sous_Projets.Remove(Projet.sous_Projets[listBox_sousProjet.SelectedIndex]);

                addAllSousProjectInListBoxAndComboList(true);

                Main.Utilities.SaveResources();
            }
        }

        #endregion

        // TACHE
        #region
        private Sous_Projet selectedSP = new Sous_Projet();
        private bool modify;

        internal void addAllTacheInListView(bool erase, Sous_Projet sous_Projet, string selectedTache = null)
        {
            pictureBox_descendreTache.Visible = false;
            pictureBox_monterTache.Visible = false;
            label_monterTache.Visible = false;
            label_descendreTache.Visible = false;

            if (erase)
            {
                listBox_tache.Items.Clear();
            }

            foreach (var tache in sous_Projet.Tâches)
            {
                listBox_tache.Items.Add(tache.Nom_de_la_tâche);
                pictureBox_delete.Visible = true;
            }

            if (listBox_tache.Items.Count != 0)
            {
                listBox_tache.SelectedIndex = 0;
            }

            if (selectedTache != null)
            {
                listBox_tache.SelectedItem = selectedTache;
            }

            if (listBox_tache.Items.Count == 0)
            {
                pictureBox_delete.Visible = false;
            }
        }

        /// <summary>
        /// Montre/Cache les flèches pour monter descendre si on est au extremiter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_tache_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_tache.SelectedIndex == listBox_tache.Items.Count - 1)
            {
                pictureBox_monterTache.Visible = true;
                label_monterTache.Visible = true;
                pictureBox_descendreTache.Visible = false;
                label_descendreTache.Visible = false;
            }
            else if (listBox_tache.SelectedIndex == 0)
            {
                pictureBox_monterTache.Visible = false;
                label_monterTache.Visible = false;
                pictureBox_descendreTache.Visible = true;
                label_descendreTache.Visible = true;
            }
            else
            {
                pictureBox_monterTache.Visible = true;
                label_monterTache.Visible = true;
                pictureBox_descendreTache.Visible = true;
                label_descendreTache.Visible = true;
            }

            if (listBox_tache.Items.Count <= 1)
            {
                pictureBox_descendreTache.Visible = false;
                pictureBox_monterTache.Visible = false;
                label_monterTache.Visible = false;
                label_descendreTache.Visible = false;
            }
        }

        /// <summary>
        /// Monte d'un cran l'élément séléctionner dans la listBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_monterTache_MouseDown(object sender, MouseEventArgs e)
        {
            modify = true;

            string selectedTache = selectedSP.Tâches[listBox_tache.SelectedIndex].Nom_de_la_tâche;

            ListExtensions.Move(selectedSP.Tâches, listBox_tache.SelectedIndex, MoveDirection.Up);

            addAllTacheInListView(true, selectedSP, selectedTache);

            if (listBox_tache.SelectedIndex == 0)
            {
                pictureBox_monterTache.Visible = false;
                label_monterTache.Visible = false;
                pictureBox_descendreTache.Visible = true;
                label_descendreTache.Visible = true;
            }
            else
            {
                pictureBox_monterTache.Visible = true;
                label_monterTache.Visible = true;
                pictureBox_descendreTache.Visible = true;
                label_descendreTache.Visible = true;
            }
        }

        private void pictureBox_descendreTache_MouseDown(object sender, MouseEventArgs e)
        {
            modify = true;

            string selectedTache = selectedSP.Tâches[listBox_tache.SelectedIndex].Nom_de_la_tâche;

            ListExtensions.Move(selectedSP.Tâches, listBox_tache.SelectedIndex, MoveDirection.Down);

            addAllTacheInListView(true, selectedSP, selectedTache);

            if (listBox_tache.SelectedIndex == listBox_tache.Items.Count - 1)
            {
                pictureBox_monterTache.Visible = true;
                label_monterTache.Visible = true;
                pictureBox_descendreTache.Visible = false;
                label_descendreTache.Visible = false;
            }
            else
            {
                pictureBox_monterTache.Visible = true;
                label_monterTache.Visible = true;
                pictureBox_descendreTache.Visible = true;
                label_descendreTache.Visible = true;
            }
        }

        /// <summary>
        /// Séléctionne un sous projet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_sousProjet_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var souspr in Projet.sous_Projets)
            {
                if (souspr.Nom_du_sous_projet.Equals(comboBox_sousProjet.SelectedItem))
                {
                    selectedSP = souspr;

                    addAllTacheInListView(true, selectedSP);
                }
            }
        }

        /// <summary>
        /// Supprime la tâche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_delete_MouseDown(object sender, MouseEventArgs e)
        {
            modify = true;

            DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer " + selectedSP.Tâches[listBox_tache.SelectedIndex].Nom_de_la_tâche + " ?", "Sûre ?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                selectedSP.Tâches.Remove(selectedSP.Tâches[listBox_tache.SelectedIndex]);

                addAllTacheInListView(true, selectedSP);

                Main.Utilities.SaveResources();
            }
        }

        #endregion
    }
}