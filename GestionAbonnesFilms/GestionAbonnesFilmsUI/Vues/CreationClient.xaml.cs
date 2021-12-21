using GestionAbonnesFilmsLibrary.Donnees;
using GestionAbonnesFilmsLibrary.Models;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GestionAbonnesFilmsUI.Vues
{
    /// <summary>
    /// Logique d'interaction pour CreationClient.xaml
    /// </summary>
    public partial class CreationClient : Window
    {
        private DonneesClient _donneesClient;
        private ClientModele client;

        public DonneesClient DonneesClient
        {
            get {
                if (_donneesClient is null)
                {
                    _donneesClient = new DonneesClient();

                }
                return _donneesClient;
            }
            set { _donneesClient = value; }
        }

        public CreationClient()
        {
            InitializeComponent();
        }

        private void Click_Creer(object sender, RoutedEventArgs e)
        {
            AjouterClient();
        }

        private void Click_Annuler(object sender, RoutedEventArgs e)
        {

        }

        private void AjouterClient() 
        {
            
            try
            {

                //création des objets client
                client = new ClientModele();
                
                //vérifie si le format de l'adresse courriel est bien écrit
                MailAddress courriel = new MailAddress(txtCourriel.Text);

                //vérifie si les champs sont bien remplis
                if (this.txtNom.Text == "" || this.txtNom.Text == "nom" || this.txtPrenom.Text == "" || this.txtPrenom.Text == "prenom"
                    || this.txtMotPasse.Password == "" || this.txtMotPasseConfirm.Password == "mot de passe"
                    || this.txtCourriel.Text == "" || this.txtCourrielConfirm.Text == "courriel" || this.txtCourrielConfirm.Text == ""
                    || this.txtCourriel.Text == "courriel"  || string.IsNullOrEmpty(this.cbxSexe.Text))
                {
                    MessageBox.Show("Veillez bien remplir tous les champs, s'il vous plait!");
                }
                else if (this.cbxSexe.Text == "Masculin" || this.cbxSexe.Text == "Féminin")
                {
                    client.Nom = txtNom.Text;
                    client.Prenom = txtPrenom.Text;
                    client.Sexe = cbxSexe.SelectedItem.ToString();
                    client.Courriel = txtCourriel.Text;
                    client.DateInscription = DateTime.Now;

                    if (ValiderMotPasseEtCourriel() && DonneesClient.SiNonExistant(client))
                    {
                        DonneesClient.AjouterNouveauElement(client);
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
            if (txtMotPasse.Password.Length >= longueur && txtMotPasseConfirm.Password.Length >= longueur) 
            {
                if (this.txtMotPasse.Password == this.txtMotPasseConfirm.Password)
                {
                    valide = true;
                }
                else
                {
                    MessageBox.Show("les Mots de passe ne sont pas identiques");
                    valide = false;
                }

                if (this.txtCourriel.Text == this.txtCourrielConfirm.Text)
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
