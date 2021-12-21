using System;
using System.Collections.Generic;
using System.Text;

namespace GestionAbonnesFilmsLibrary.Models
{
    public class CarteDeCreditModele
    {
        public int IdCarte { get; set; }
        public int NumeroCarte { get; set; }
        public DateTime DateExpiration { get; set; }
        public int CodeSecret { get; set; }
        public ClientModele Client { get; set; }
    }
}
