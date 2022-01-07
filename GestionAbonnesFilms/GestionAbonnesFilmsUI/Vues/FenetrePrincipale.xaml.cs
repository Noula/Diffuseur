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
        //private DonneesFilm _donneesFilm;
        //public DonneesClient DonneesClients
        //{
        //    get
        //    {
        //        if (_donneesClient is null)
        //        {
        //            _donneesClient = new DonneesClient();

        //        }
        //        return _donneesClient;
        //    }
        //    set { _donneesClient = value; }
        //}

        //public DonneesFilm DonneesFilms
        //{
        //    get
        //    {
        //        if (_donneesFilm is null)
        //        {
        //            _donneesFilm = new DonneesFilm();

        //        }
        //        return _donneesFilm;
        //    }
        //    set { _donneesFilm = value; }
        //}

        //public ClientVueModele ClientVueModele { get; set; }

        //private List<ClientModele> _listeClientsModele;
        //public List<ClientModele> ListeClientsModele
        //{
        //    get { return _listeClientsModele; }
        //    set { _listeClientsModele = value; }
        //}

        public FenetrePrincipale()
        {
            InitializeComponent();
            //DatagridListeClient.ItemsSource = DonneesClients.ListeDesClients;
            //DatagridListeFilm.ItemsSource = DonneesFilms.ListeFilm;

        }

        private void btnCreer_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            CreationClient creer = new CreationClient();
            creer.Activate();
            creer.Show();            
        }

        private void btnSupprim_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnModif_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAjoutFilm_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AjoutFilm ajout = new AjoutFilm();
            ajout.Activate();
            ajout.Show();
        }
    }
}
