using System;
using System.Collections.Generic;
using System.IO;
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
        public static string Message { get; private set; }

        public ClientModele(string nom, 
                            string prenom, 
                            String sexe, 
                            string statut, 
                            string nomUtilisateur, 
                            string motPasse, 
                            DateTime dateInscription, 
                            string courriel, 
                            string adresseIp) : base(nom, prenom, sexe, statut)
        {
            this.Nom = nomUtilisateur;
            this.MotDePasse = motPasse;
            this.Courriel = courriel;
            this.DateInscription = dateInscription;
            this.AdresseIP= adresseIp;
        }
        public ClientModele()
        {

        }

        /* Constructeur*/
        public ClientModele(string[] data) : base(data[Constante.ColonneNom], data[Constante.ColonnePrenom], data[Constante.ColonneSexe], data[Constante.ColonneStatut])
        {
            this.Nom = data[Constante.ColonneNomUtilisteur];
            this.MotDePasse = data[Constante.ColonneMotDePasse];
            this.Courriel = data[Constante.ColonneCourriel];
            this.AdresseIP = data[Constante.ColonneAdresseIp];
            try
            {
                DateTime dateInscription = this.DateInscription;
                DateTime.TryParse(data[Constante.ColonneDateInscription], out dateInscription);             
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }


        //information du clinet
        public string Information()
        {
            string infos = Nom + ";" + Prenom + ";" + Sexe + ";" + " client ;" + Nom+ ";" + MotDePasse + ";" + Courriel + ";" + DateTime.Now;
            return infos;

        }

        /* focntion Abonnement
        * pour un client qui s'abonne pour la prémière fois
        retourne vrai*/
        public bool Abonnenment()
        {
            if (!SiExiste(Courriel))
            {
                StreamWriter ecrire = new StreamWriter(PersonnesModele.fichierInscrire, append: true);
                ecrire.WriteLine(Information());
                ecrire.Close();
                return true;
            }
            return false;
        }

        //Vérifie si existe
        public bool SiExiste(string courriel)
        {
            bool existe = false;
            LectureFichierPersonne();
            foreach (PersonnesModele pers in PersonnesModele.listPersonnes)
            {
                switch (pers.Status)
                {
                    case Constante.Client:
                        if (courriel == ((ClientModele)pers).Courriel)
                        {
                            existe = true;
                            Message = "Un utilisateur utilise déjà ce courriel";
                        }
                        break;
                    case Constante.Employe:
                        if (courriel == ((EmployeModele)pers).CodeUtilisateur)
                        {
                            existe = true;
                            Message = "Un utilisateur utilise déjà ce courriel";
                        }
                        break;
                    default:
                        continue;
                }
            }
            return existe;
        }
    }
}
