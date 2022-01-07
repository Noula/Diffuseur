using GestionAbonnesFilmsUI.Models;
using GestionAbonnesFilmsUI.Services;
using GestionAbonnesFilmsUI.Utilitaires;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Mail;
using System.Text;
using System.Windows;

namespace GestionAbonnesFilmsUI.VueModeles
{
    public class ClientVueModele:NotifyPropertyChanged, IGestionDonnees<ClientModele>
    {
        //private List<ClientModele> _listeClientsModele;
        //public List<ClientModele> ListeClientsModele
        //{
        //    get { return _listeClientsModele; }
        //    set { _listeClientsModele = value; }
        //}

        private string _codeUtilisateur;

        public string CodeUtilisateur
        {
            get { return _codeUtilisateur; }
            set 
            {
                _codeUtilisateur = value;
                OnPropertyChanged("CodeUtilisateur");
            }
        }


        private string _motDePasseConfirm;

        public string MotDePasseConfirm
        {
            get { return _motDePasseConfirm; }
            set 
            { 
                _motDePasseConfirm = value;
                OnPropertyChanged("MotDePasseConfirm");
            }
        }


        private string _confirmationCourriel;

        public string ConfirmationCourriel
        {
            get { return _confirmationCourriel; }
            set
            { 
                _confirmationCourriel = value;
                OnPropertyChanged("ConfirmationCourriel");
            }
        }

        private ClientModele _clientModele;
        public ClientModele ClientModele
        {
            get 
            { 
                if(_clientModele == null)
                {
                    _clientModele = new ClientModele();
                }
                return _clientModele; 
            }
            set
            {
                _clientModele = value;
                OnPropertyChanged("ClientModele");
            }
        }

        private ObservableCollection<ClientModele> _ListeClientModele;

        public ObservableCollection<ClientModele> ListeClientModele
        {
            get { return _ListeClientModele; }
            set
            {
                _ListeClientModele = value;
                OnPropertyChanged("ListeClient");
            }
        }

        public ClientVueModele()
        {
            ListeClientModele = new ObservableCollection<ClientModele>(ObtenirDonneesClient());
        }
        public List<ClientModele> ObtenirDonneesClient()
        {

            var donneeClient = new DonneesClient();

            return donneeClient.ListeDesClients;
        }

        /// <summary>
        /// Fonction ajout du client
        /// </summary>
        /// <param name="client"></param>        
        public void AjouterNouveauElement(ClientModele client)
        {
             
            var indexDernierClient = ListeClientModele.Count - 1;
            client.IdClient = ListeClientModele[indexDernierClient].IdClient + 1;
            _ListeClientModele.Add(client);
        }
        /// <summary>
        /// Fonction supprimer client
        /// </summary>
        /// <param name="entite"></param>
        public void SupprimerElement(ClientModele client)
        {
            ListeClientModele.Remove(client);
            var indexDernierClient = ListeClientModele.Count - 1;
            client.IdClient = ListeClientModele[indexDernierClient].IdClient - 1;
        }

        /// <summary>
        ///Fonction de mise à ajour du client
        /// </summary>
        public void MiseAJourElement(ClientModele elementAmettreAjour)
        {
            var liste = new List<ClientModele>(ListeClientModele);
            var indexClient = liste.FindIndex(x => x.IdClient == elementAmettreAjour.IdClient);
            _ListeClientModele[indexClient] = elementAmettreAjour;
        }

        ///
        public bool SiNonExistant(ClientModele entite)
        {
            var liste = new List<ClientModele>(ListeClientModele);
            bool courrielExistant = false;
            var courrielExiste = liste.Find(x => x.Courriel == entite.Courriel);
            if (courrielExiste is null)
                courrielExistant = true;

            return courrielExistant;
        }


        private void AjouterClient()
        {

            try
            {

                //création des objets client
               

                //vérifie si le format de l'adresse courriel est bien écrit
                MailAddress courriel = new MailAddress(ClientModele.Courriel);

                //vérifie si les champs sont bien remplis
                if (ClientModele.Nom== "" || ClientModele.Nom == "nom" || ClientModele.Prenom == "" || ClientModele.Prenom == "prenom"
                    || ClientModele.MotDePasse == "" || ClientModele.MotDePasse == "mot de passe"
                    || ClientModele.Courriel == "" || ClientModele.Courriel == "courriel" || ConfirmationCourriel == ""
                    || ConfirmationCourriel == "courriel" || string.IsNullOrEmpty(ClientModele.Sexe))
                {
                    MessageBox.Show("Veillez bien remplir tous les champs, s'il vous plait!");
                }
                else if (ClientModele.Sexe == "Masculin" || ClientModele.Sexe == "Féminin")
                {
                    
                    ClientModele.DateInscription = DateTime.Now;

                    if (ValiderMotPasseEtCourriel() && SiNonExistant(ClientModele))
                    {
                        AjouterNouveauElement(ClientModele);
                    }
                    else
                    {
                        MessageBox.Show("Ce client existe déjà");
                    }
                }
                else
                {
                    MessageBox.Show("Veillez selectionner votre sexe, s'il vous plait!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur:\n" + ex.Message);
            }
        }

        //Vérifie si le mot de passe et le courriel sont bien saisis
        public bool ValiderMotPasseEtCourriel()
        {
            int longueur = 8;
            bool valide = false;
            if (ClientModele.MotDePasse.Length >= longueur && MotDePasseConfirm.Length >= longueur)
            {
                if (ClientModele.MotDePasse == MotDePasseConfirm)
                {
                    valide = true;
                }
                else
                {
                    MessageBox.Show("les Mots de passe ne sont pas identiques");
                    valide = false;
                }

                if (ClientModele.Courriel == ConfirmationCourriel)
                {
                    valide = true;
                }
                else
                {
                    MessageBox.Show("les courriels ne sont pas identiques");
                    valide = false;
                }
            }
            else
            {
                MessageBox.Show("La longueur du mot de passe doit être de 8 caractères minimum");
                valide = false;
            }
            return valide;
        }

    }
}
