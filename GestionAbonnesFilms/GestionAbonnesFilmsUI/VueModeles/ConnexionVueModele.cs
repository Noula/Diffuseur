using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionAbonnesFilmsUI.VueModeles
{
    public class ConnexionVueModele :Conductor<object>
    {
        private EmployeVueModele _employeVueModele;
        public ConnexionVueModele(EmployeVueModele employeVM)
        {
            _employeVueModele = employeVM;
            ActivateItemAsync(_employeVueModele);
        }
        
    }
}
