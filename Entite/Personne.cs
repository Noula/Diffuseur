using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abonnement.Entite
{
    public abstract class Personne
    {
        public string Nom { get; set; }

        public string Prenom { get; set; }
        public char Sexe { get; set; }
        public string Status { get; set; }
    }
}
