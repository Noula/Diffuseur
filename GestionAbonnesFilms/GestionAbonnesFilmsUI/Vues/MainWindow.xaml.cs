using GestionAbonnesFilmsUI.VueModeles;
using GestionAbonnesFilmsUI.Vues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GestionAbonnesFilmsUI.Vues
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void button_Connecter(object sender, RoutedEventArgs e)
        {
            AppelFenetrePrincipal(txtCodeUtilisateur.Text, txtMotDePasse.Password);
        }

        private void button_Incrire(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// definit et ouvre la fenêtre correspondante selon le type d'utilisateur
        /// </summary>
        /// <param name="nomUtilisateur"></param>
        /// <param name="motDePasse"></param>
        private void AppelFenetrePrincipal(string nomUtilisateur, string motDePasse) 
        {
            ConnexionVueModele.connexion(nomUtilisateur, motDePasse);
            string cnx = ConnexionVueModele.typeUtilisateur;
            switch (cnx)
            {
                case "client":

                    break;
                case "employé lecture seule":
                    FenetrePrincipale principale = new FenetrePrincipale();
                    principale.Activate();
                    principale.Show();
                    break;
                case "employé lecture totale":
                    MessageBox.Show("vous êtes en mode lecture totale");
                    break;
                default:
                    MessageBox.Show(cnx);
                    break;
            }            
        }


        //Vide le champs de text lors qu'on click dans le champs de text
        private void Remove_CodeUtilisateur(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCodeUtilisateur.Text) || txtCodeUtilisateur.Text.Equals("Code Utilisateur"))
            {
                txtCodeUtilisateur.Text = "";
            }
        }

        //affiche le message par defaut lors que le champs de text est vide
        private void Leave_CodeUtilisateur(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCodeUtilisateur.Text))
                txtCodeUtilisateur.Text = "Code Utilisateur";
        }

        private void Remove_MotdePasse(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtMotDePasse.Password) || txtMotDePasse.Password.Equals("MotdePasse"))
            {
                txtMotDePasse.Password = "";
            }
        }

        private void Leave_MotdePasse(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtMotDePasse.Password))
                txtMotDePasse.Password = "MotdePasse";
        }
    }
}
