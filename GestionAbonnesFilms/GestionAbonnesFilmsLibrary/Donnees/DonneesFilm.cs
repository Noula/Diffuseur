using GestionAbonnesFilmsLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionAbonnesFilmsLibrary.Donnees
{
   public class DonneesFilm
    {
        //Charge la liste des films
        public List<FilmModele> CreationJeuDeDonneesFilm()
        {
            List<FilmModele> donneesFilm = new List<FilmModele>();
            donneesFilm.Add(new FilmModele { Titre = "Titre0", Description = "C'est l'histoire d'une fille perdue dans le désert", Duree = 75 });
            donneesFilm.Add(new FilmModele { Titre = "Titre1", Description = "C'est l'histoire d'une fille perdue dans le désert", Duree = 60 });
            donneesFilm.Add(new FilmModele { Titre = "Titre2", Description = "C'est l'histoire d'une famille en crosade d'exploration du monde entier", Duree = 86 });
            return donneesFilm;
        }
    }

    
}
