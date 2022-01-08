using GestionAbonnesFilmsUI.Services;
using GestionAbonnesFilmsUI.Models;
using GestionAbonnesFilmsUI.VueModeles;
using System;
using System.Collections.Generic;
using System.Text;
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
    /// Logique d'interaction pour FenetrePrincipale.xaml
    /// </summary>
    public partial class FenetrePrincipale : Window
    {
        private DonneesClient _donneesClient;
        

        public FenetrePrincipale()
        {
            InitializeComponent();


        }

        private void btnCreer_Click(object sender, RoutedEventArgs e)
        {
            //this.Hide();
            //CreationClientVue creer = new CreationClientVue();
            //creer.Activate();
            //creer.Show();            
        }

        private void btnSupprim_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnModif_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAjoutFilm_Click(object sender, RoutedEventArgs e)
        {
            //this.Hide();
            //AjoutFilm ajout = new AjoutFilm();
            //ajout.Activate();
            //ajout.Show();
        }
    }
}
