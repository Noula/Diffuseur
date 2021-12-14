using Chanel_MovieGestionAbonnesFilmsLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace GestionAbonnesFilmsLibrary.Models
{
    public class PersonnesModele
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Sexe { get; set; }
        public string Status { get; set; }

        public static List<PersonnesModele> listPersonnes = new List<PersonnesModele>();

        // Chemins des fichiers
        public static string fichierPersonne = @"../Fichiers/Personne.txt";
        public static string fichierInscrire = Path.GetFullPath("GestionAbonnesFilmsLibrary/FichiersInscrire.txt");

        public PersonnesModele()
        {
        }
        public PersonnesModele(string nom, string prenom, string sexe, string statut)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Sexe = sexe;
            this.Status = statut;
        }

        //Lecture du fichier et retourne la liste de mots
        public void LectureFichierPersonne()
        {
            List<String> contenu = Utils.lireFichier(fichierPersonne); // Recuperer le contenu du fichier

            if (contenu != null) // cas pas exception generee
            {
                contenu.ForEach(delegate (string ligne)
                {
                    string[] data = ligne.Split(';');

                    switch (data[Constante.ColonneStatut])
                    {

                        case Constante.Client:
                            ClientModele client = new ClientModele(data);
                            PersonnesModele.listPersonnes.Add(client);
                            break;
                        default:
                            Console.WriteLine(ligne);
                            break;
                    }
                });
            }
            else // cas exception generee
            {

            }
        }
    }
}
