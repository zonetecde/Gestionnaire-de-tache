using System.Windows.Forms;

namespace Gestionnaire_de_tâche__Last_
{
    public partial class UserControl_Haut_du_tableau : UserControl
    {
        public UserControl_Haut_du_tableau(Sous_Projet sous_Projet)
        {
            InitializeComponent();
            Sous_Projet = sous_Projet;
        }

        public Sous_Projet Sous_Projet { get; set; }
    }
}