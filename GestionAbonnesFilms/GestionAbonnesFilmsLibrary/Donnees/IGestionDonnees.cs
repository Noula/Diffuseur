using GestionAbonnesFilmsLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionAbonnesFilmsLibrary.Donnees
{
    public interface IGestionDonnees <T>
    {
        /// Todo chercher a utiliser methode generique au prochain factory
        /// Cette classe --IGestionDonnees-- gère toutes les manipulations des cartes de crédit et des films.  
        /// <summary>
        /// Ajout d'un nouveau élément(film ou carte de crédit)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entite"></param>
        public void AjouterNouveauElement(T entite);

        /// <summary>
        /// Supprimer un nouveau élément(film ou carte de crédit)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entite"></param>
        public void SupprimerElement(T entite);

        /// <summary>
        /// Modification d'un nouveau élément(film ou carte de crédit)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entite"></param>
        public void MiseAJourElement(T entite);

        /// <summary>
        /// Vérifie l'existance d'un nouveau élément(film ou carte de crédit)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entite"></param>
        public bool SiNonExistant(T entite);
    }
}
