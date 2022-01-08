using GestionAbonnesFilmsUI.Models;
using System;
using System.Collections.Generic;

namespace GestionAbonnesFilmsUI.Services
{
    public class DonneesClient : IGestionDonnees<ClientModele>
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
            ListeDesClients.Add(new ClientModele { IdClient = 0, Nom = "tete0", Prenom = "Tata0", Courriel = "courriell@gmail.com", Sexe = "Masculin", MotDePasse = "tetevi0", AdresseIP = "123.342.453", DateInscription = DateTime.Now, Status = "C0", ListeCartesCredits = new List<CarteDeCreditModele>() }); ; ;
            ListeDesClients.Add(new ClientModele { IdClient = 1, Nom = "tete1", Prenom = "Tata1", Courriel = "courrieel@gmail.com", Sexe = "Masculin", MotDePasse = "tetevi1", AdresseIP = "123.342.453", DateInscription = DateTime.Now, Status = "C1", ListeCartesCredits = new List<CarteDeCreditModele>() });
            ListeDesClients.Add(new ClientModele { IdClient = 2, Nom = "tete2", Prenom = "Tata2", Courriel = "courriiel@gmail.com", Sexe = "Masculin", MotDePasse = "tetevi2", AdresseIP = "123.342.453", DateInscription = DateTime.Now, Status = "C2", ListeCartesCredits = new List<CarteDeCreditModele>() });
            ListeDesClients.Add(new ClientModele { IdClient = 3, Nom = "tete3", Prenom = "Tata3", Courriel = "couriel@gmail.com", Sexe = "Masculin", MotDePasse = "tetevi3", AdresseIP = "123.342.453", DateInscription = DateTime.Now, Status = "C3", ListeCartesCredits = new List<CarteDeCreditModele>() });
            ListeDesClients.Add(new ClientModele { IdClient = 4, Nom = "tete4", Prenom = "Tata4", Courriel = "corriel@gmail.com", Sexe = "Masculin", MotDePasse = "tetevi4", AdresseIP = "123.342.453", DateInscription = DateTime.Now, Status = "C4", ListeCartesCredits = new List<CarteDeCreditModele>() });
            return ListeDesClients;
        }



        /// <summary>
        /// Fonction ajout du client
        /// </summary>
        /// <param name="client"></param>        
        public void AjouterNouveauElement(ClientModele client)
        {

            var indexDernierClient = ListeDesClients.Count - 1;
            client.IdClient = ListeDesClients[indexDernierClient].IdClient + 1;
            _listeDesClients.Add(client);
        }
        /// <summary>
        /// Fonction supprimer client
        /// </summary>
        /// <param name="entite"></param>
        public void SupprimerElement(ClientModele client)
        {
            _listeDesClients.Remove(client);
            var indexDernierClient = ListeDesClients.Count - 1;
            client.IdClient = ListeDesClients[indexDernierClient].IdClient - 1;
        }

        /// <summary>
        ///Fonction de mise à ajour du client
        /// </summary>
        public void MiseAJourElement(ClientModele elementAmettreAjour)
        {
            var indexClient = _listeDesClients.FindIndex(x => x.IdClient == elementAmettreAjour.IdClient);
            _listeDesClients[indexClient] = elementAmettreAjour;
        }

        ///
        public bool SiNonExistant(ClientModele entite)
        {
            bool courrielExistant = false;
            var courrielExiste = ListeDesClients.Find(x => x.Courriel == entite.Courriel);
            if (courrielExiste is null)
                courrielExistant = true;

            return courrielExistant;
        }

    }
}
