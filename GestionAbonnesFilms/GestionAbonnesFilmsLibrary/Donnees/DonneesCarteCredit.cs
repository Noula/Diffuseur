using GestionAbonnesFilmsLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionAbonnesFilmsLibrary.Donnees
{
    public class DonneesCarteCredit
    {
        //Charge la liste des cartes de crédit
        public List<CarteDeCreditModele> CreationJeuDeDonneesFilm()
        {
            List<CarteDeCreditModele> donneesFilm = new List<CarteDeCreditModele>();

            donneesFilm.Add(new CarteDeCreditModele { NumeroCarte = 4193 - 2393 - 7402 - 9985, CodeSecret = 876, Client = new ClientModele() });
            donneesFilm.Add(new CarteDeCreditModele { NumeroCarte = 4183 - 3293 - 9402 - 9085, CodeSecret = 594, Client = new ClientModele() });
            donneesFilm.Add(new CarteDeCreditModele { NumeroCarte = 4893 - 4393 - 6402 - 9485, CodeSecret = 952, Client = new ClientModele() });
            donneesFilm.Add(new CarteDeCreditModele { NumeroCarte = 4763 - 2593 - 5402 - 9385, CodeSecret = 281, Client = new ClientModele() });
            donneesFilm.Add(new CarteDeCreditModele { NumeroCarte = 4987 - 6293 - 2402 - 9285, CodeSecret = 987, Client = new ClientModele() });
            return donneesFilm;
        }
    }
}
