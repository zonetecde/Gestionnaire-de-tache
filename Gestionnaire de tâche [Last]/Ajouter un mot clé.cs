using System;
using System.Windows.Forms;

namespace Gestionnaire_de_tâche__Last_
{
    public partial class Ajouter_un_mot_clé : Form
    {
        public Ajouter_un_mot_clé(Tâche tache, UserControl_Tâche userControl_Tâche)
        {
            InitializeComponent();
            Tache = tache;
            UserControl_Tâche = userControl_Tâche;

            this.Icon = Gestionnaire_de_tâche__Last_.Properties.Resources.icon_add;

            label_title.Text = "Ajouter un mot clé pour " + Tache.Nom_de_la_tâche;

            this.ActiveControl = label_title;
        }

        public Tâche Tache { get; }
        public UserControl_Tâche UserControl_Tâche { get; }

        private void Ajouter_un_mot_clé_Load(object sender, EventArgs e)
        {
            this.ActiveControl = Textbox_nom;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(Textbox_nom.Text) || Textbox_nom.Text.Equals("Mot clé...")))
            {
                Tache.Mots_Clés.Insert(0, Textbox_nom.Text);
                UserControl_Tâche.AddMotClé(Tache.Mots_Clés[0]);

                this.Close();
            }
            else
            {
                MessageBox.Show("Vous devez renseigner un mot clé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Textbox_nom_Enter(object sender, EventArgs e)
        {
            if (Textbox_nom.Text.Equals("Mot clé..."))
            {
                Textbox_nom.Text = string.Empty;
            }
        }

        private void Textbox_nom_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button_add_Click(this, null);
            }
        }
    }
}