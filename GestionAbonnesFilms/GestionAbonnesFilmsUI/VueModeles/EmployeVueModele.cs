using GestionAbonnesFilmsUI.Models;
using System.Collections.Generic;

namespace GestionAbonnesFilmsUI.VueModeles
{
    public class EmployeVueModele
    {
        private List<EmployeModele> _ListeEmployeModele;

        public List<EmployeModele> ListeEmployeModele
        {
            get { return _ListeEmployeModele; }
            set { _ListeEmployeModele = value; }
        }

    }
}