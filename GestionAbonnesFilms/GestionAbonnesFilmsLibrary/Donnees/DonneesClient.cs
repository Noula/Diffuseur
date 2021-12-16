using GestionAbonnesFilmsLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionAbonnesFilmsLibrary.Donnees
{
    public class DonneesClient:IGestionClient
    {
        private List<ClientModele> _listeDesClients;

        public List<ClientModele> ListeDesClients
        {
            get { return _listeDesClients; }
            set { _listeDesClients = value; }
        }

        //Construteur
        public DonneesClient()
        {
            ListeDesClients = new List<ClientModele>();
            ListeDesClients = CreationJeuDeDonnees();
        }
        //Charge la liste des clients
        public List<ClientModele> CreationJeuDeDonnees()
        {
            ListeDesClients.Add(new ClientModele { Nom = "tete0", Prenom = "Tata0", Courriel = "courriell@gmail.com", Sexe = "Masculin", MotDePasse = "tetevi0", AdresseIP = "123.342.453", DateInscription = DateTime.Now, Status = "C0", ListeCartesCredits = new List<CarteDeCreditModele>() });
            ListeDesClients.Add(new ClientModele { Nom = "tete1", Prenom = "Tata1", Courriel = "courrieel@gmail.com", Sexe = "Masculin", MotDePasse = "tetevi1", AdresseIP = "123.342.453", DateInscription = DateTime.Now, Status = "C1", ListeCartesCredits = new List<CarteDeCreditModele>() });
            ListeDesClients.Add(new ClientModele { Nom = "tete2", Prenom = "Tata2", Courriel = "courriiel@gmail.com", Sexe = "Masculin", MotDePasse = "tetevi2", AdresseIP = "123.342.453", DateInscription = DateTime.Now, Status = "C2", ListeCartesCredits = new List<CarteDeCreditModele>() });
            ListeDesClients.Add(new ClientModele { Nom = "tete3", Prenom = "Tata3", Courriel = "couriel@gmail.com", Sexe = "Masculin", MotDePasse = "tetevi3", AdresseIP = "123.342.453", DateInscription = DateTime.Now, Status = "C3", ListeCartesCredits = new List<CarteDeCreditModele>() });
            ListeDesClients.Add(new ClientModele { Nom = "tete4", Prenom = "Tata4", Courriel = "corriel@gmail.com", Sexe = "Masculin", MotDePasse = "tetevi4", AdresseIP = "123.342.453", DateInscription = DateTime.Now, Status = "C4", ListeCartesCredits = new List<CarteDeCreditModele>() });
            return ListeDesClients;
        }



        /// <summary>
        /// Fonction ajout du client
        /// </summary>
        /// <param name="client"></param>        
        public void AjouterNouveauElement(ClientModele client)
        {

            _listeDesClients.Add(client);
          
        }
        /// <summary>
        /// Fonction supprimer client
        /// </summary>
        /// <param name="entite"></param>
        public void SupprimerElement(ClientModele entite)
        {
            _listeDesClients.Remove(entite);
            
        }

        /// <summary>
        ///Fonction de mise à ajour du client
        /// </summary>
        public void MiseAJourElement(ClientModele elementAmettreAjour)
        {
            var indexClient = _listeDesClients.FindIndex(x => x.IdClient == elementAmettreAjour.IdClient);
            _listeDesClients[indexClient] = elementAmettreAjour;

        }
    }
}
