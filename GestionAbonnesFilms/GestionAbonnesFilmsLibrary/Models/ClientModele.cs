using System;
using System.Collections.Generic;
using System.Text;

namespace GestionAbonnesFilmsLibrary.Models
{
    public class ClientModele : PersonnesModele
    {
        public DateTime DateInscription { get; set; }
        public string Courriel { get; set; }
        public string MotDePasse { get; set; }
        public string AdresseIP { get; set; }

        public List<CarteDeCreditModele> ListeCartesCredits { get; set; }
    }
}
