using System;
using System.Collections.Generic;
using System.Text;

namespace GestionAbonnesFilmsLibrary.Models
{
   public class EmployeModele :PersonnesModele
    {
        public DateTime DateEmbauche { get; set; }
        public string CodeUtilisateur { get; set; }
        public string MotDePasse { get; set; }
        public string TypeAcces { get; set; }
    }
}
