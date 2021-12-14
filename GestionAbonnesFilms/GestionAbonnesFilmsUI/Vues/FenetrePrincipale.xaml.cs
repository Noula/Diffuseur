using GestionAbonnesFilmsLibrary.Models;
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

        //public ClientVueModele ClientVueModele { get; set; }

        private List<ClientModele> _listeClientsModele;
        public List<ClientModele> ListeClientsModele
        {
            get { return _listeClientsModele; }
            set { _listeClientsModele = value; }
        }

        public FenetrePrincipale()
        {
            InitializeComponent();
        }

        private void btnCreer_Click(object sender, RoutedEventArgs e)
        {
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
    }
}
