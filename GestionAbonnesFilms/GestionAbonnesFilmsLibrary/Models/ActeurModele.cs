using System;
using System.Collections.Generic;
using System.Text;

namespace GestionAbonnesFilmsLibrary.Models
{
    public class ActeurModele
    {
        public string NomPersonnage { get; set; }
        public DateTime DebutEmploi { get; set; }
        public DateTime FinEmploi { get; set; }
        public decimal Cachet { get; set; }
    }
}
