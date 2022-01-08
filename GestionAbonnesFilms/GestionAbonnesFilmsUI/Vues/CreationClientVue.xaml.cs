using GestionAbonnesFilmsUI.Services;
using GestionAbonnesFilmsUI.Models;
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
using GestionAbonnesFilmsUI.VueModeles;

namespace GestionAbonnesFilmsUI.Vues
{
    /// <summary>
    /// Logique d'interaction pour CreationClient.xaml
    /// </summary>
    public partial class CreationClientVue : Window
    {
        
        private ClientModele client;
        public CreationClientVue()
        {
            InitializeComponent();
        }
        private ClientVueModele _donneesClient;
        public ClientVueModele DonneesClients
        {
            get
            {
                if (_donneesClient is null)
                {
                    _donneesClient = new ClientVueModele();

                }
                return _donneesClient;
            }
            set { _donneesClient = value; }
        }

        private void Click_Creer(object sender, RoutedEventArgs e)
        {
            //AjouterClient();
        }

        private void Click_Annuler(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
