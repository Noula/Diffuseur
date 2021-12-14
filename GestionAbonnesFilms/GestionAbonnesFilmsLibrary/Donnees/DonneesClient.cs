﻿using GestionAbonnesFilmsLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionAbonnesFilmsLibrary.Donnees
{
    public class DonneesClient
    {
        public List<ClientModele> ObtenirTousLesClients()
        {
            List<ClientModele> donneesClients = new List<ClientModele>();
            donneesClients.Add(new ClientModele { Nom = "tete0", Prenom = "Tata0", Courriel = "courriell@gmail.com", Sexe = "Masculin", MotDePasse = "tetevi0", AdresseIP = "123.342.453", DateInscription = DateTime.Now, Status = "C0", ListeCartesCredits = new List<CarteDeCreditModele>() });
            donneesClients.Add(new ClientModele { Nom = "tete1", Prenom = "Tata1", Courriel = "courrieel@gmail.com", Sexe = "Masculin", MotDePasse = "tetevi1", AdresseIP = "123.342.453", DateInscription = DateTime.Now, Status = "C1", ListeCartesCredits = new List<CarteDeCreditModele>() });
            donneesClients.Add(new ClientModele { Nom = "tete2", Prenom = "Tata2", Courriel = "courriiel@gmail.com", Sexe = "Masculin", MotDePasse = "tetevi2", AdresseIP = "123.342.453", DateInscription = DateTime.Now, Status = "C2", ListeCartesCredits = new List<CarteDeCreditModele>() });
            donneesClients.Add(new ClientModele { Nom = "tete3", Prenom = "Tata3", Courriel = "couriel@gmail.com", Sexe = "Masculin", MotDePasse = "tetevi3", AdresseIP = "123.342.453", DateInscription = DateTime.Now, Status = "C3", ListeCartesCredits = new List<CarteDeCreditModele>() });
            donneesClients.Add(new ClientModele { Nom = "tete4", Prenom = "Tata4", Courriel = "corriel@gmail.com", Sexe = "Masculin", MotDePasse = "tetevi4", AdresseIP = "123.342.453", DateInscription = DateTime.Now, Status = "C4", ListeCartesCredits = new List<CarteDeCreditModele>() });
            return donneesClients;
        }

       


    }
}
