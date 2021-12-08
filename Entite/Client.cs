using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abonnement.Entite
{
    class Client: Personne
    {
        public DateTime DateInscription { get; set; }
        public string Courriel { get; set; }
        public string MotDePasse { get; set; }
        public string AdresseIP { get; set; }

        public List<CarteCredit> ListeCartesCredits { get; set; }
    }
}
