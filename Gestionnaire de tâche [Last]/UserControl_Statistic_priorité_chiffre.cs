using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gestionnaire_de_tâche__Last_
{
    public partial class UserControl_Statistic_priorité_chiffre : UserControl
    {
        internal int nbDeFoisUtilisées = 0;

        public Priorité Etat { get; }
        public Projet Projet { get; }
        public Statistique_nombre Statistique_Nombre { get; }

        public UserControl_Statistic_priorité_chiffre(Priorité etat, Projet projet, Statistique_nombre statistique_Nombre)
        {
            InitializeComponent();

            panel_etat.BackColor = etat.Couleur_de_l_etat;
            labelstate.Text = etat.Texte_de_l_etat;

            Etat = etat;
            Projet = projet;
            Statistique_Nombre = statistique_Nombre;
            comboBox_sousProj.Items.Clear();
            comboBox_sousProj.Items.Add("Tous");

            foreach (var sousProjet in Projet.sous_Projets)
            {
                comboBox_sousProj.Items.Add(sousProjet.Nom_du_sous_projet);
            }

            initializeForAll();

            comboBox_sousProj.SelectedIndex = 0;

            this.ActiveControl = label_chiffre2;
        }

        /// <summary>
        /// Set l'index séléctionné
        /// </summary>
        /// <param name="selectedIndex"></param>
        internal void SetSelectedIndex(int selectedIndex)
        {
            comboBox_sousProj.SelectedIndex = selectedIndex;
        }

        /// <summary>
        /// Initialize les statistiques de l'état sur tout les sous projets
        /// </summary>
        private void initializeForAll()
        {
            int nbFoisUtilisé = 0;
            int nbFoisUtiliséTotal = 0;

            foreach (var sousProjet in Projet.sous_Projets)
            {
                foreach (var tache in sousProjet.Tâches)
                {
                    if (Etat.Equals(Main.Utilities.resource.priorités[tache.Priorité_de_la_tâche]))
                        nbFoisUtilisé++;
                }
            }

            int nbTache = 0;
            foreach (var projetA in Main.Utilities.resource.projets)
            {
                if (Projet == projetA)
                {
                    foreach (var sousProjet in projetA.sous_Projets)
                    {
                        foreach (var tache in sousProjet.Tâches)
                        {
                            if (Etat.Equals(Main.Utilities.resource.priorités[tache.Priorité_de_la_tâche]))
                                nbFoisUtiliséTotal++;

                            nbTache++;
                        }
                    }
                }
            }

            double value = Math.Round(((double)nbFoisUtilisé / nbTache) * 100, 2);
            nbDeFoisUtilisées = nbFoisUtilisé;

            if (nbTache > 1)
                label_chiifre1.Text = "Utilisé " + nbFoisUtilisé.ToString() + " fois sur " + nbTache + " prioritées (" + value + "%)" + " dans ce projet";
            else
                label_chiifre1.Text = "Utilisé " + nbFoisUtilisé.ToString() + " fois sur " + nbTache + " prioritée (" + value + "%)" + " dans ce projet";

            label_chiffre2.Text = "Utilisé " + nbFoisUtiliséTotal.ToString() + " fois dans tous les projets";

            mettreEnCouleur();
        }

        private void UserControl_Statistic_priorité_chiffre_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Affiche les bon statistiques pour le sousProjet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_sousProj_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Statistique_Nombre.onlyMoreThan0)
            {
                if (comboBox_sousProj.SelectedIndex == 0)
                {
                    initializeForAll();
                }
                else
                {
                    foreach (Sous_Projet sousProjet in Projet.sous_Projets)
                    {
                        if (sousProjet.Nom_du_sous_projet.Equals(comboBox_sousProj.SelectedItem))
                        {
                            showStatisticFor(sousProjet);
                        }
                    }
                }

                Statistique_Nombre.SetAllComboBoxForPriority(comboBox_sousProj.SelectedIndex);
            }
            else
            {
                comboBox_sousProj.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Initialize les statistiques de l'état sur un sousProjet
        /// </summary>
        private void showStatisticFor(Sous_Projet sousProjet)
        {
            int nbFoisUtilisé = 0;
            int nbFoisUtiliséTotal = 0;

            foreach (var tache in sousProjet.Tâches)
            {
                if (Etat.Equals(Main.Utilities.resource.priorités[tache.Priorité_de_la_tâche]))
                    nbFoisUtilisé++;
            }

            int nbTache = 0;

            foreach (var sousProj in Projet.sous_Projets)
            {
                foreach (var tache in sousProj.Tâches)
                {
                    if (Etat.Equals(Main.Utilities.resource.priorités[tache.Priorité_de_la_tâche]))
                        nbFoisUtiliséTotal++;

                    if (sousProj.Equals(sousProjet))
                    {
                        nbTache++;
                    }
                }
            }

            double value;
            if (nbTache != 0)
                value = Math.Round(((double)nbFoisUtilisé / nbTache) * 100, 2);
            else
                value = 0;

            if (nbTache > 1)
                label_chiifre1.Text = "Utilisé " + nbFoisUtilisé + " fois sur " + nbTache + " tâches (" + value + "%)" + " dans le sous projet séléctionné";
            else
                label_chiifre1.Text = "Utilisé " + nbFoisUtilisé + " fois sur " + nbTache + " tâche (" + value + "%)" + " dans le sous projet séléctionné";

            label_chiffre2.Text = "Utilisé " + nbFoisUtiliséTotal.ToString() + " fois dans toutes les tâches de ce projet";

            mettreEnCouleur();
        }

        /// <summary>
        /// Met en couleur les chiffres
        /// </summary>
        private void mettreEnCouleur()
        {
            setFontForNumberAndPourcentSigne(label_chiifre1);
            setFontForNumberAndPourcentSigne(label_chiffre2);
        }

        private void setFontForNumberAndPourcentSigne(RichTextBox label)
        {
            for (int i = 0; i < label.Text.Length; i++)
            {
                if (Char.IsNumber(label.Text[i]) || label.Text[i].Equals('%'))
                {
                    label.SelectionStart = i;
                    label.SelectionLength = 1;

                    label.SelectionColor = Color.Red;
                    label.SelectionFont = new Font(label_chiifre1.Font, FontStyle.Bold);
                }
            }
        }

        private void label_chiifre1_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = labelstate;
        }
    }
}