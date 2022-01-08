using GestionAbonnesFilmsUI.Services;
using GestionAbonnesFilmsUI.Models;
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
    /// Logique d'interaction pour AjoutFilm.xaml
    /// </summary>
    public partial class AjoutFilm : Window
    {
        private FilmModele film;
        public AjoutFilm()
        {
            InitializeComponent();
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

        private void ajoutFilm_Click(object sender, RoutedEventArgs e)
        {
            film = new FilmModele();
            if (DonneesFilm.SiNonExistant(film))
            {
                DonneesFilm.AjouterNouveauElement(film);
            }
            else
            {
                MessageBox.Show("Ce film existe déjà");
            }
        }
    }
}
