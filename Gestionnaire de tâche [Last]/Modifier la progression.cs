using System;
using System.Windows.Forms;

namespace Gestionnaire_de_tâche__Last_
{
    public partial class Modifier_la_progression : Form
    {
        public Modifier_la_progression(Tâche tache, UserControl_Tâche UC)
        {
            InitializeComponent();

            this.Icon = Gestionnaire_de_tâche__Last_.Properties.Resources.progress;
            Tache = tache;
            this.UC = UC;

            label_title.Text += Tache.Nom_de_la_tâche;

            trackBar_progression.Value = Tache.Progression;

            label_pourcent.Text = trackBar_progression.Value + "%";
        }

        public Tâche Tache { get; }
        public UserControl_Tâche UC { get; }

        private void Modifier_la_progression_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Modifie le label pour la valeur choisit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBar_progression_Scroll(object sender, EventArgs e)
        {
            label_pourcent.Text = trackBar_progression.Value + "%";
        }

        private void trackBar_progression_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_done_Click(this, null);
            }
        }

        /// <summary>
        /// Edit de la progression
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_done_Click(object sender, EventArgs e)
        {
            Tache.Progression = trackBar_progression.Value;

            UC.UpdateProgression();

            this.Close();
        }
    }
}