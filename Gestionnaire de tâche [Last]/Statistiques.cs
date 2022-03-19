using System;
using System.Windows.Forms;

namespace Gestionnaire_de_tâche__Last_
{
    public partial class Statistiques : Form
    {
        public Projet Projet { get; }

        public Statistiques(Projet projet)
        {
            InitializeComponent();

            this.Icon = Gestionnaire_de_tâche__Last_.Properties.Resources.icon_add;
            Projet = projet;
        }

        private void Statistiques_Load(object sender, EventArgs e)
        {
        }

        private void label_graphCircular_Click(object sender, EventArgs e)
        {
            Statistiques_Graph statistiques_Graph = new Statistiques_Graph(Projet);
            statistiques_Graph.ShowDialog();
        }

        private void Btn_statistiqueParChiffre_MouseDown(object sender, MouseEventArgs e)
        {
            Statistique_nombre statistique_Nombre = new Statistique_nombre();
            statistique_Nombre.ShowDialog();
        }
    }
}