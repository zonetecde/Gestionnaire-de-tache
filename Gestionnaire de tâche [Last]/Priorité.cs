using System.Drawing;

namespace Gestionnaire_de_tâche__Last_
{
    public class Priorité
    {
        public Priorité(Color couleur_de_l_etat, string texte_de_l_etat)
        {
            Texte_de_l_etat = texte_de_l_etat;
            Couleur_de_l_etat = couleur_de_l_etat;
        }

        public string Texte_de_l_etat { get; internal set; }
        public Color Couleur_de_l_etat { get; internal set; }
    }
}