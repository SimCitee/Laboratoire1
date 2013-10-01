using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratoire1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        
        static void Main()
        {
            //Objet pour échanger de l'information entre les formulaires
            Global global = new Global();
           
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Application.Run(new frmLogin(global));

            if (global.Profile != null)
            {
                Application.Run(new frmMenu(global));

            }
            //Console.WriteLine("retour " + global.Profile.Nom);
        }
    }
}
