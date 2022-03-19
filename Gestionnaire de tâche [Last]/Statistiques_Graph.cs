using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Gestionnaire_de_tâche__Last_
{
    public partial class Statistiques_Graph : Form
    {
        public Statistiques_Graph(Projet projet)
        {
            InitializeComponent();
            Projet = projet;

            this.Icon = Gestionnaire_de_tâche__Last_.Properties.Resources.icon_stat;
        }

        public Projet Projet { get; }

        private void Statistiques_Load(object sender, EventArgs e)
        {
            initializeStateGraphic(false);

            initializeSousProjet();

            listBox_sousProjet.SelectedIndex = 0;
        }

        private void initializeSousProjet()
        {
            listBox_sousProjet.Items.Clear();

            listBox_sousProjet.Items.Add("Tous");

            foreach (var sousProjet in Projet.sous_Projets)
            {
                listBox_sousProjet.Items.Insert(1, sousProjet.Nom_du_sous_projet);
            }
        }

        private void initializeStateGraphic(bool isPrio)
        {
            chart_graphic.Series["s1"].Points.Clear();

            if (isPrio)
            {
                chart_graphic.Titles[0] = new System.Windows.Forms.DataVisualization.Charting.Title("Prioritée de tous les sous projets");
            }
            else
            {
                if (chart_graphic.Titles.Count == 0)
                    chart_graphic.Titles.Add("Statut(s) de tous les sous projets");
                else
                    chart_graphic.Titles[0] = new System.Windows.Forms.DataVisualization.Charting.Title("Statut de tous les sous projets");
            }

            List<Color> colors = new List<Color>();

            List<int> stateCounter = new List<int>();
            foreach (var etat in Main.Utilities.resource.etats)
            {
                stateCounter.Add(0);
            }

            // Nombre de tâche
            int x = 0;

            foreach (var sousProjet in Projet.sous_Projets)
            {
                foreach (var tache in sousProjet.Tâches)
                {
                    if (isPrio)
                        stateCounter[tache.Priorité_de_la_tâche] += 1;
                    else
                        stateCounter[tache.State_de_la_tâche] += 1;

                    x++;
                }
            }

            for (int i = 0; i < stateCounter.Count; i++)
            {
                if (stateCounter[i] != 0)
                {
                    if (isPrio)
                        colors.Add(Main.Utilities.resource.priorités[i].Couleur_de_l_etat);
                    else
                        colors.Add(Main.Utilities.resource.etats[i].Couleur_de_l_etat);
                }
            }


            for (int i = 0; i < stateCounter.Count; i++)
            {
                if (stateCounter[i] != 0)
                {
                    if (isPrio)
                    {
                        // Calcul le pourcentage
                        // Combien de fois il y a cette valeur divisé par le nombre de part dans le gateau le tout multiplié par 100
                        double value = Math.Round(((double)stateCounter[i] / x) * 100, 2);

                        chart_graphic.Series["s1"].Points.AddXY(Main.Utilities.resource.priorités[i].Texte_de_l_etat + " " + value.ToString() + "%", stateCounter[i].ToString());
                    }
                    else
                    {
                        // Calcul le pourcentage
                        double value = Math.Round(((double)stateCounter[i] / x) * 100, 2);

                        chart_graphic.Series["s1"].Points.AddXY(Main.Utilities.resource.etats[i].Texte_de_l_etat + " " + value.ToString() + "%", stateCounter[i].ToString());
                    }
                }
            }

            chart_graphic.PaletteCustomColors = colors.ToArray();
        }

        /// <summary>
        /// Change le graphic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Switch__OnValueChange(object sender, EventArgs e)
        {
            if (listBox_sousProjet.SelectedItem.Equals("Tous"))
            {
                if (Switch_.Value)
                    initializeStateGraphic(false);
                else
                    initializeStateGraphic(true);
            }
            else
            {
                foreach (var sousProjet in Projet.sous_Projets)
                {
                    if (sousProjet.Nom_du_sous_projet.Equals(listBox_sousProjet.SelectedItem))
                    {
                        initializeGraphicFor(sousProjet);
                    }
                }
            }
        }

        /// <summary>
        /// Montre le graphique du bon sous projet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_sousProjet_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var sousProjet in Projet.sous_Projets)
            {
                if (sousProjet.Nom_du_sous_projet.Equals(listBox_sousProjet.SelectedItem))
                {
                    initializeGraphicFor(sousProjet);
                }
                else if (listBox_sousProjet.SelectedItem.Equals("Tous"))
                {
                    initializeStateGraphic(!Switch_.Value);
                }
            }
        }

        private void initializeGraphicFor(Sous_Projet sousProjet)
        {
            chart_graphic.Series["s1"].Points.Clear();

            if (!Switch_.Value)
            {
                chart_graphic.Titles[0] = new System.Windows.Forms.DataVisualization.Charting.Title("Prioritée du sous projet "
                     + sousProjet.Nom_du_sous_projet);
            }
            else
            {
                if (chart_graphic.Titles.Count == 0)
                    chart_graphic.Titles.Add("Statut(s) du sous projet "
                         + sousProjet.Nom_du_sous_projet);
                else
                    chart_graphic.Titles[0] = new System.Windows.Forms.DataVisualization.Charting.Title("Statut de tous les sous projets");
            }

            List<Color> colors = new List<Color>();

            List<int> stateCounter = new List<int>();
            foreach (var etat in Main.Utilities.resource.etats)
            {
                stateCounter.Add(0);
            }

            // Nombre de part qui vont être affichées dans le graphique
            int x = 0;

            foreach (var tache in sousProjet.Tâches)
            {
                if (!Switch_.Value)
                    stateCounter[tache.Priorité_de_la_tâche] += 1;
                else
                    stateCounter[tache.State_de_la_tâche] += 1;

                x++;
            }

            for (int i = 0; i < stateCounter.Count; i++)
            {
                if (stateCounter[i] != 0)
                {
                    if (!Switch_.Value)
                        colors.Add(Main.Utilities.resource.priorités[i].Couleur_de_l_etat);
                    else
                        colors.Add(Main.Utilities.resource.etats[i].Couleur_de_l_etat);
                }
            }


            for (int i = 0; i < stateCounter.Count; i++)
            {
                if (stateCounter[i] != 0)
                {
                    if (!Switch_.Value)
                    {
                        // Calcul le pourcentage
                        // Combien de fois il y a cette valeur divisé par le nombre de part dans le gateau le tout multiplié par 100
                        double value = Math.Round(((double)stateCounter[i] / x) * 100, 0);

                        chart_graphic.Series["s1"].Points.AddXY(Main.Utilities.resource.priorités[i].Texte_de_l_etat + " " + value.ToString() + "%", stateCounter[i].ToString());
                    }
                    else
                    {
                        // Calcul le pourcentage
                        double value = Math.Round(((double)stateCounter[i] / x) * 100, 0);

                        chart_graphic.Series["s1"].Points.AddXY(Main.Utilities.resource.etats[i].Texte_de_l_etat + " " + value.ToString() + "%", stateCounter[i].ToString());
                    }
                }
            }

            chart_graphic.PaletteCustomColors = colors.ToArray();
        }
    }
}