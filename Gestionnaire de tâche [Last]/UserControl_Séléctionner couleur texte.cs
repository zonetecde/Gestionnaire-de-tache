using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gestionnaire_de_tâche__Last_
{
    public partial class UserControl_Séléctionner_couleur_texte : UserControl
    {
        public Tchat Tchat { get; }

        public UserControl_Séléctionner_couleur_texte(Tchat tchat)
        {
            InitializeComponent();
            Tchat = tchat;
        }

        private void label_defaultColor_MouseEnter(object sender, EventArgs e)
        {
            label_defaultColor.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void label_defaultColor_MouseLeave(object sender, EventArgs e)
        {
            label_defaultColor.BackColor = Color.White;
        }

        private void label_defaultColor_MouseDown(object sender, MouseEventArgs e)
        {
            Tchat.SetSelectedTextColorTo(Color.Black);

            this.Hide();
        }

        private void xuiColorPane1_Click(object sender, EventArgs e)
        {
            Tchat.SetSelectedTextColorTo(xuiColorPane1.SelectedColor);

            this.Hide();
        }

        private void xuiColorPane2_Click(object sender, EventArgs e)
        {
            Tchat.SetSelectedTextColorTo(xuiColorPane2.SelectedColor);

            this.Hide();
        }

        private void xuiColorPane3_Click(object sender, EventArgs e)
        {
            Tchat.SetSelectedTextColorTo(xuiColorPane3.SelectedColor);

            this.Hide();
        }
    }
}