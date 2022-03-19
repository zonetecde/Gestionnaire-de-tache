using System;
using System.Collections.Generic;

namespace Gestionnaire_de_tâche__Last_
{
    [Serializable()]
    public class Resource
    {
        public Resource()
        {
            projets = new List<Projet>();
            etats = new List<Etat>();
            priorités = new List<Priorité>();

            BackupInterval = 0;
            NbDeLancementDeLappTotal = 0;
        }

        public List<Projet> projets { get; set; }
        public List<Etat> etats { get; set; }
        public List<Priorité> priorités { get; set; }
        public int BackupInterval { get; set; }
        public int NbDeLancementDeLappTotal { get; set; }
    }
}