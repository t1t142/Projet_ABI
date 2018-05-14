using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_ABI
{
    public partial class frmlistClient : Form
    {

 
        public frmlistClient()
        {
           
            InitializeComponent();
            afficheClients();
        }

        private void grdClients_CellDoubleClick(object sender, EventArgs e)
        {
              
              Int32 iSClient; 
                           
              iSClient = this.grdClients.CurrentRow.Index;
             
              Client leClient = Donnees.ArrayClient[iSClient] as Client;
              
              frmConsultationClient frmVisu = new frmConsultationClient(leClient);             
              frmVisu.ShowDialog();            
              this.afficheClients();
        }

       


        
        private void afficheClients()
        {
            
            DataTable dt = new DataTable();
            DataRow dr; // ligne de la datatable
            Int32 i; // var de boucle
                     // ajout à la datatable de 3 colonnes personnalisées
            dt.Columns.Add(new DataColumn("Numéro",typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("Raison Sociale", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Adresse", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Adresse2", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Ville", typeof(System.String)));
            dt.Columns.Add(new DataColumn("CP", typeof(System.String)));
            dt.Columns.Add(new DataColumn("tel", typeof(System.String)));
            // boucle remplissage de la DataTable à partir de la collection
            for (i = 0; i < Donnees.ArrayClient.Count; i++)
            {
                // instanciation DataRow (=ligne de DataTable)
                dr = dt.NewRow();
                // affectation des 3 colonnes
                // la collection voit les éléments comme des ‘Object’
                // ==>'caster' en MStagiaire pour en voir les attributs
                dr[0] = ((Client)(Donnees.ArrayClient[i])).Num;
                dr[1] = ((Client)(Donnees.ArrayClient[i])).Rs;
                dr[2] = ((Client)(Donnees.ArrayClient[i])).Adresse;
                dr[3] = ((Client)(Donnees.ArrayClient[i])).Adresse2;
                dr[4] = ((Client)(Donnees.ArrayClient[i])).Ville;
                dr[5] = ((Client)(Donnees.ArrayClient[i])).Cp;
                dr[6] = ((Client)(Donnees.ArrayClient[i])).Tel;
                // ajout de la ligne à la Datatable
                // (la propriété Rows est elle-même une collection...)
                dt.Rows.Add(dr);
            } // fin de boucle
              // déterminer l'origine des données à afficher en DataGridView
            this.grdClients.DataSource = dt;
            // refraîchir l'affichage (même pas utile…)
            this.grdClients.Refresh();
            dt = null; // pas vraiment utile non plus…
            dr = null;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            
                // instancie un form de saisie de stagiaire et l'affiche en modal
                frmNewClient frmAjout = new frmNewClient();
                // si on sort de la saisie par OK
                if (frmAjout.ShowDialog() == DialogResult.OK)
                {
                    // régénère l'affichage du dataGridView
                    afficheClients();
                }
          
        }

        private void frmlistClient_Load(object sender, EventArgs e)
        {

        }
    }
}
