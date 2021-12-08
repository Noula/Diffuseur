using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abonnement.Entite
{
    public class Acteur: Personne
    {
        public string NomPersonnage { get; set; }
        public DateTime DebutEmploi { get; set; }
        public DateTime FinEmploi { get; set; }
        public decimal Cachet { get; set; }

    }
}
