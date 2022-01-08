using GestionAbonnesFilmsUI.Services;
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
    /// Logique d'interaction pour FenetreDeBase.xaml
    /// </summary>
    public partial class FenetreDeBase : Window
    {

        private DonneesClient _donneesClient;

        public DonneesClient DonneesClient
        {
            get
            {
                if (_donneesClient is null)
                {
                    _donneesClient = new DonneesClient();

                }
                return _donneesClient;
            }
            set { _donneesClient = value; }
        }

        private DonneesFilm _donneesFilm;

        public DonneesFilm DonneesFilm
        {
            get
            {
                if (_donneesFilm is null)
                {
                    _donneesFilm = new DonneesFilm();

                }
                return _donneesFilm;
            }
            set { _donneesFilm = value; }
        }

        public FenetreDeBase()
        {   

            InitializeComponent();
        }
    }
}
