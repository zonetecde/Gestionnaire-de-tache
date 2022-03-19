using System;
using System.Collections.Generic;

namespace Gestionnaire_de_tâche__Last_
{
    [Serializable()]
    public class Projet
    {
        public Projet(string couleur_du_projet, string nom_du_projet, string desc_du_projet, int id_du_projet, DateTime creation_du_projet, DateTime? fin_du_projet, string solution_path, string executable_debug_path, string executable_release_path)
        {
            Couleur_du_projet = couleur_du_projet;
            Nom_du_projet = nom_du_projet;
            Desc_du_projet = desc_du_projet;
            Id_du_projet = id_du_projet;
            Date_creation_du_projet = creation_du_projet;
            Fin_du_projet = fin_du_projet;
            Solution_path = solution_path;
            Executable_debug_path = executable_debug_path;
            Executable_release_path = executable_release_path;
            sous_Projets = new List<Sous_Projet>();
        }

        /// <summary>
        /// Génère un projet à partir d'un autre avec une ID différente
        /// </summary>
        /// <param name="projet"></param>
        public Projet(Projet projet)
        {
            Random rdn = new Random();

            Couleur_du_projet = projet.Couleur_du_projet;
            Nom_du_projet = projet.Nom_du_projet;
            Desc_du_projet = projet.Desc_du_projet;
            Id_du_projet = rdn.Next(0, 2147483647);
            Date_creation_du_projet = projet.Date_creation_du_projet;
            Fin_du_projet = projet.Fin_du_projet;
            Solution_path = projet.Solution_path;
            Executable_debug_path = projet.Executable_debug_path;
            Executable_release_path = projet.Executable_release_path;
            sous_Projets = projet.sous_Projets;
        }

        public Projet()
        {
        }

        public string Couleur_du_projet { get; set; }

        public string Nom_du_projet { get; set; }
        public string Desc_du_projet { get; set; }

        public int Id_du_projet { get; set; }

        public DateTime Date_creation_du_projet { get; set; }
        public DateTime? Fin_du_projet { get; set; }

        public string Solution_path { get; set; }
        public string Executable_debug_path { get; set; }
        public string Executable_release_path { get; set; }

        public List<Sous_Projet> sous_Projets { get; set; }
    }
}