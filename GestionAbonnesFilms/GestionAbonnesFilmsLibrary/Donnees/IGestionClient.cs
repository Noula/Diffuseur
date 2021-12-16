using GestionAbonnesFilmsLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionAbonnesFilmsLibrary.Donnees
{
    public interface IGestionClient
    {
        public void AjouterNouveauElement(ClientModele entite);
        public void SupprimerElement(ClientModele entite);
        public void MiseAJourElement(ClientModele entite);
    }
}
