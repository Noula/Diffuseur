using GestionAbonnesFilmsLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionAbonnesFilmsLibrary.Donnees
{
    public class DonneesFilm : IGestionDonnees<FilmModele>
    {
        public List<FilmModele> _listeFilm;

        public List<FilmModele> ListeFilm
        {
            get { return _listeFilm; }
            set { _listeFilm = value; }
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        public DonneesFilm()
        {
            ListeFilm = new List<FilmModele>();
            ListeFilm = CreationJeuDeDonneesFilm();
        }
        //Charge la liste des films
        public List<FilmModele> CreationJeuDeDonneesFilm()
        {
            ListeFilm.Add(new FilmModele { Titre = "Titre0", Description = "C'est l'histoire d'une fille perdue dans le désert", Duree = 75 });
            ListeFilm.Add(new FilmModele { Titre = "Titre1", Description = "C'est l'histoire d'une fille perdue dans le désert", Duree = 60 });
            ListeFilm.Add(new FilmModele { Titre = "Titre2", Description = "C'est l'histoire d'une famille en crosade d'exploration du monde entier", Duree = 86 });
            return ListeFilm;
        }

        public void AjouterNouveauElement(FilmModele entite)
        {
            ListeFilm.Add(entite);
        }

        public void SupprimerElement(FilmModele entite)
        {
           ListeFilm.Remove(entite);
        }

        public void MiseAJourElement(FilmModele elementAmettreAjour)
        {
            var indexClient = _listeFilm.FindIndex(x => x.IdFilm == elementAmettreAjour.IdFilm);
            ListeFilm[indexClient] = elementAmettreAjour;
        }

        public bool SiNonExistant(FilmModele entite)
        {
            if (ListeFilm.Contains(entite))
                return true;

            return false; ;
        }
    }

    public interface IGestionDonnees
    {
    }
}
