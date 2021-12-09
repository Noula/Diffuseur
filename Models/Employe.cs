using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abonnement.Models
{
   public class Employe: Personne
    {
        public DateTime DateEmbauche { get; set; }
        public string CodeUtilisateur { get; set; }
        public string MotDePasse { get; set; }
        public string TypeAcces { get; set; }

    }
}
