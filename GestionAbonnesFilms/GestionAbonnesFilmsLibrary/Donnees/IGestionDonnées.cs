using System;
using System.Collections.Generic;
using System.Text;

namespace GestionAbonnesFilmsLibrary.Donnees
{
    public interface IGestionDonnées
    {
        //Todo chercher a utiliser methode generique au prochain factory
        public void AjouterNouveauElement<T>(T entite);
        public void SupprimerElement<T>(T entite);
        public void MiseAJourElement<T>(T entite);
    }
}
