using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abonnement.Entite
{
    class CarteCredit
    {
        public int NumeroCarte { get; set; }
        public DateTime DateExpiration { get; set; }
        public int CodeSecret { get; set; }

        public Client clients { get; set; }
    }
}
