using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestionnaire_de_tâche__Last_
{
    public partial class UserControl_priorité : UserControl
    {
        public UserControl_Tâche UserControl_Tâche { get; }
        public Tâche Tache { get; }
        private const int STATE_HEIGHT = 37;

        public UserControl_priorité(UserControl_Tâche userControl_Tâche, Tâche tache)
        {
            InitializeComponent();
            UserControl_Tâche = userControl_Tâche;
            Tache = tache;

            ajouterToutesLesStates();
        }

        private void UserControl_priorité_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Ajoute une prio dans la liste
        /// Ajoute le ContextMenuStrip uniquement si ce n'est pas une prio de base
        /// </summary>
        /// <param name="couleur_de_l_etat">La couleur de l'état</param>
        /// <param name="texte_de_l_etat">Le texte qui va avec</param>
        /// <param name="location">La location spécifique si il y en a</param>
        private void addOneMoreState(Color couleur_de_l_etat, string texte_de_l_etat, Point location = new Point())
        {
            // 37 étant la hauteur d'un état

            // Ajout du panel de l'état
            Panel panel_etat = new Panel();
            panel_etat.BackColor = couleur_de_l_etat;
            panel_etat.Size = new Size(131, STATE_HEIGHT);
            panel_etat.BorderStyle = BorderStyle.FixedSingle;
            panel_etat.Name = texte_de_l_etat;

            if (location != new Point())
            {
                panel_etat.Location = location;
            }
            else if (!ligne)
            {
                panel_etat.Location = new Point(x, y);
                x += panel_etat.Width;
                Size = new Size(Size.Width, Size.Height + (STATE_HEIGHT));
                ligne = true;
            }
            else
            {
                panel_etat.Location = new Point(x, y);
                y += panel_etat.Height;
                x = 0;
                ligne = false;
            }


            Label label_state = new Label();
            label_state.Text = texte_de_l_etat;
            label_state.Font = new Font("Verdana", 12, FontStyle.Regular);
            label_state.TextAlign = ContentAlignment.MiddleCenter;
            label_state.Dock = DockStyle.Fill;

            label_state.MouseDown += new System.Windows.Forms.MouseEventHandler(label_state_MouseDown);

            if (!(texte_de_l_etat.Equals("Pas définit") || texte_de_l_etat.Equals("Terminer") || texte_de_l_etat.Equals("En cours") ||
                texte_de_l_etat.Equals("Échouer") || texte_de_l_etat.Equals("En attente") || texte_de_l_etat.Equals("Annuler")))
            {
                label_state.ContextMenuStrip = contextMenuStrip_option;
            }

            panel_etat.Controls.Add(label_state);

            Controls.Add(panel_etat);
        }

        /// <summary>
        /// Actualize toutes les priorités
        /// </summary>
        internal void ActualizeAll()
        {
            ajouterToutesLesStates();
        }

        /// <summary>
        /// Ajoute une state car on en à ajouter
        /// 
        /// Conserve la location du dernier UC qui est "Autre..."
        /// Enlève le userControl "Autre"
        /// Ajoute le UC avec le nouveau state à la place de l'autre
        /// Et enfin ajoute le UC Autre...
        /// </summary>
        internal void AddState()
        {
            Point location = new Point();
            for (int i = 0; i < Controls.Count; i++)
            {
                if (i == Controls.Count - 1)
                {
                    Controls[i].Visible = false;
                    location = Controls[i].Location;
                }
            }

            addOneMoreState(Main.Utilities.resource.priorités[Main.Utilities.resource.priorités.Count - 1].Couleur_de_l_etat,
                Main.Utilities.resource.priorités[Main.Utilities.resource.priorités.Count - 1].Texte_de_l_etat, location);

            addOneMoreState(Color.White, "Nouveau...");
        }


        /// <summary>
        /// Séléctionne la priorité et l'attribut à la tâche
        /// Ou ouvre l'ajouteur de priorité
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_state_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Label label = sender as Label;

                if (!label.Text.Equals("Nouveau..."))
                {
                    for (int i = 0; i < Main.Utilities.resource.priorités.Count; i++)
                    {
                        if (Main.Utilities.resource.priorités[i].Texte_de_l_etat.Equals(label.Text))
                        {
                            Tache.State_de_la_tâche = i;

                            UserControl_Tâche.UpdateTâche(Tache);

                            Hide();
                        }
                    }
                }
                else
                {
                    // Customisation
                    Ajouter_un_état ajouter_Un_État_popup = new Ajouter_un_état(UserControl_Tâche);
                    ajouter_Un_État_popup.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Supprime puis ajoute toutes les priorités
        /// </summary>
        bool ligne = false;
        int x = 0, y = 0;
        private void ajouterToutesLesStates()
        {
            foreach (Control ctrl in Controls)
            {
                ctrl.Visible = false;
            }

            ligne = false;
            x = 0;
            y = 0;

            for (int i = 0; i < Main.Utilities.resource.etats.Count; i++)
            {
                if (Tache.State_de_la_tâche != i)
                {
                    addOneMoreState(Main.Utilities.resource.priorités[i].Couleur_de_l_etat, Main.Utilities.resource.priorités[i].Texte_de_l_etat);
                }
            }

            // Ajoute la customisation          
            addOneMoreState(Color.White, "Nouveau...");

            Size = new Size(Size.Width, Size.Height - 2);
        }

        /// <summary>
        /// Supprime une priorité
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Priorité temp = null;
            temp = getSelecteState(sender, temp);

            Main.Utilities.resource.priorités.Remove(temp);

            ajouterToutesLesStates();
        }

        /// <summary>
        /// Modifie la tâche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Priorité temp = null;
            temp = getSelecteState(sender, temp);

            // Contient l'index de l'état modifié
            int index = Main.Utilities.resource.priorités.IndexOf(temp);

            Ajouter_une_priorité ajouter_Une_Priorité = new Ajouter_une_priorité(UserControl_Tâche, temp);
            ajouter_Une_Priorité.ShowDialog();

            foreach (Control ctrl in Controls)
            {
                if (ctrl is Panel)
                {
                    Panel panel = ctrl as Panel;

                    if (panel.Name.Equals(temp.Texte_de_l_etat))
                    {
                        panel.Name = Main.Utilities.resource.priorités[index].Texte_de_l_etat;
                        panel.BackColor = Main.Utilities.resource.priorités[index].Couleur_de_l_etat;

                        foreach (Label label in panel.Controls)
                        {
                            label.Text = Main.Utilities.resource.priorités[index].Texte_de_l_etat;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Retourne la priorité sur laquel on a cliqué
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="temp"></param>
        /// <returns></returns>
        private static Priorité getSelecteState(object sender, Priorité temp)
        {
            Control sourceControl = null;

            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    sourceControl = owner.SourceControl;
                }
            }

            foreach (var priorité in Main.Utilities.resource.priorités)
            {
                if (priorité.Texte_de_l_etat.Equals(sourceControl.Text))
                {
                    temp = priorité;
                }
            }

            return temp;
        }
    }
}
