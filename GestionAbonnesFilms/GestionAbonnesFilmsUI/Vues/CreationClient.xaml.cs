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

                //création des objets client et personne
                // ClientModele client = new ClientModele(txtNom, txtPrenom, txtSexe, "client", txtCodeUtilisateur, txtMotPasse, DateTime.Now, txtCourriel, )
                // ClientModele client = new Model.Client(textBoxNom.Text, confirmationMotpasse.Text, textBoxCourriel1.Text, "client");

                ClientModele client = new ClientModele();
                //vérifie si le format de l'adresse courriel est bien écrit
                MailAddress courriel = new MailAddress(txtCourriel.Text);

                client.Nom = txtNom.Text;
                client.Prenom = txtPrenom.Text;
                client.Sexe = cbxSexe.SelectedItem.ToString();
                client.Courriel = txtCourriel.Text;
                client.DateInscription = DateTime.Now;

                ValiderMotPasse();
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
                    //client.CreeNomUtilisateur(client.Nom, client.Prenom);
                    if (this.txtMotPasse.Password == this.txtMotPasseConfirm.Password)
                    {
                        if (this.txtCourriel.Text == this.txtCourrielConfirm.Text)
                        {
                            client.Abonnenment();
                        }
                        else
                        {
                            MessageBox.Show("Vérifiez les champs courriel");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Les mots de passe sont incorrects");
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
            finally
            {
                //MessageBox.Show(ClientModele.Message);
            }
        }

        //Valider le mot de passe
        public bool ValiderMotPasse()
        {
           int longueur = 8;
            bool valide = false;
            if (txtMotPasse.MaxLength >= longueur && txtMotPasseConfirm.MaxLength >= longueur) 
            {
                if (this.txtMotPasse.Password == this.txtMotPasseConfirm.Password)
                    valide = true;
                    MessageBox.Show("les Mots de passe ne sont pas identiques");

                if (this.txtCourriel.Text == this.txtCourrielConfirm.Text)
                    valide = true;
                MessageBox.Show("les courriels ne sont pas identiques");
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
