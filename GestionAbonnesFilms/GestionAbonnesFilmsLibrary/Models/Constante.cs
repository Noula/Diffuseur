using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAbonnesFilmsLibrary.Models
{
    class Constante
    {
        public const string Client = "client";
        public const string Employe = "employe";
        public const string Acteur = "acteur";

        //Colonne personne
        public const int ColonneNom = 0;
        public const int ColonnePrenom = 1;
        public const int ColonneSexe= 2;
        public const int ColonneStatut = 3;
        //Colonne client
        public const int ColonneNomUtilisteur = 4;
        public const int ColonneMotDePasse = 5;
        public const int ColonneCourriel = 6;
        public const int ColonneDateInscription = 7;
        //public const int colonneAdresse = 8;
        public const int ColonneAdresseIp = 9;
        //Colonne acteur
        public const int ColonneNomPersonnage = 10;
        public const int ColonneDebutEmploi = 11;
        public const int ColonneFinEmploi = 12;
        public const int ColonneCachet = 13;
        //Colonne employé
        public const int ColonneRole = 14;
        public const int ColonneDateEmbauhe = 15;
        public const int ColonneSalaire = 16;

        //Film
        public const int filmTitre = 0;
        public const int filmDesrcription = 1;
        public const int filmProducteur = 2;
        public const int filmSynopsis = 3;
        public const int filmDuree = 4;
        public const int filmNbreAbonne = 5;
        public const int filmDateSortie = 6;
        public const int filmExtension = 7;

    }
}
