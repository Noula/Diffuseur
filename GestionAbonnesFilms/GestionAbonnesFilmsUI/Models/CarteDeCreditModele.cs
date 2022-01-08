using GestionAbonnesFilmsUI.Utilitaires;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionAbonnesFilmsUI.Models
{
    public class CarteDeCreditModele : NotifyPropertyChanged
    {
        private int _IdCarte;

        public int IdCarte
        {
            get { return _IdCarte; }
            set 
            {
                _IdCarte = value;
                OnPropertyChanged("IdCarte");
            }
        }

        private int _NumeroCarte;

        public int NumeroCarte
        {
            get { return _NumeroCarte; }
            set 
            {
                _NumeroCarte = value;
                OnPropertyChanged("NumeroCarte");
            }
        }

        private DateTime _DateExpiration;

        public DateTime DateExpiration
        {
            get { return _DateExpiration; }
            set 
            { 
                _DateExpiration = value;
                OnPropertyChanged("DateExpiration");
            }
        }

        private int _CodeSecret;

        public int CodeSecret
        {
            get { return _CodeSecret; }
            set 
            {
                _CodeSecret = value;
                OnPropertyChanged("CodeSecret");
            }
        }

        private ClientModele _Client;

        public ClientModele Client
        {
            get { return _Client; }
            set 
            {
                _Client = value;
                OnPropertyChanged("Client");
            }
        }
    }
}
