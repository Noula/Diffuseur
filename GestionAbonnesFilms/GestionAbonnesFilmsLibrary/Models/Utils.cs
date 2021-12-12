using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Chanel_MovieGestionAbonnesFilmsLibrary.Models
{
    class Utils
    {
        /*Constructeur par defaut*/
        public Utils()
        { }

        /**
         * param name="cheminFichier" le fichier a lire
         * returns une liste de string representant le contenu du fichier lu
         * 
         */
        public static List<string> lireFichier(string cheminFichier)
        {
            StreamReader lire = null;
            FileStream fStream= null;
            List<string>  contenu = new List<string>();
            try
            {
                fStream = new FileStream(cheminFichier, FileMode.Open, FileAccess.Read);
                lire = new StreamReader(fStream);
                string ligne = null;
                while ((ligne = lire.ReadLine()) != null)
                {
                    contenu.Add(ligne);
                }
            }
            catch (Exception ex)
            {
                contenu = null;
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                if (lire != null)
                {
                    lire.Close();
                }
            }
            return contenu;
        }
    }
}
