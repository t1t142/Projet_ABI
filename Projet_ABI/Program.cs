using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_ABI
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
       // [STAThread]
        static void Main()
        {

            Client cl1 = new Client(9, "142", "Microsoft", " yttutyutyutyyt", "54211", " Paris", "045845212");
            Client cl2 = new Client(10, "145", "Ubisoft", " yttutyutyutyyt", "44211", " Lyon", "0458452252");

            Donnees.ArrayClient.Add(cl1);
            Donnees.ArrayClient.Add(cl2);












            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            Application.Run(new frmPrincipal());
           
            



        }
    }
}
