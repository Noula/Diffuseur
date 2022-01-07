using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionAbonnesFilmsUI.VueModeles
{
    public class ConnexionVueModele :Conductor<object>
    {
        public static string typeUtilisateur = null;
        private EmployeVueModele _employeVueModele;
        public ConnexionVueModele(EmployeVueModele employeVM)
        {
            _employeVueModele = employeVM;
            ActivateItemAsync(_employeVueModele);
        }

        //Cette fonction vérifie le type d'utilisateur
        public static void connexion(string nomUtilisateur, string motDePasse)
        {
            if (nomUtilisateur == "bertino" && motDePasse == "00040008")
            {
                typeUtilisateur = "client";
            }
            else if (motDePasse == "tetevi22")
            {
                DefinitionTypeEmploye(nomUtilisateur);
            }
            else 
            {
                typeUtilisateur = "Le nom d'utilisateur ou le mot de passe est incorrect.\nVeillez réessayer svp!";
            }
        }

        ////Vérifie si le mot de passe et le courriel sont bien saisis
        public static void DefinitionTypeEmploye(string nomUtilisateur)
        {
            //Récupère les deux premières lettres du motre
            //et compare 
            string codeUtilisateur = nomUtilisateur.Substring(0, 2);
            if(codeUtilisateur.ToUpper() == "LS")
            {
                typeUtilisateur = "employé lecture seule";
            }
            else if (codeUtilisateur.ToUpper() == "LT")
            {
                typeUtilisateur = "employé lecture totale";
            }
        }
    }
}
