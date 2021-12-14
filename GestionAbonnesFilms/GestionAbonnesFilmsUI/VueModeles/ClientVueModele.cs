using GestionAbonnesFilmsLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionAbonnesFilmsUI.VueModeles
{
    public class ClientVueModele
    {
        private List<ClientModele> _listeClientsModele;
        public List<ClientModele> ListeClientsModele
        {
            get { return _listeClientsModele; }
            set { _listeClientsModele = value; }
        }


    }
}
