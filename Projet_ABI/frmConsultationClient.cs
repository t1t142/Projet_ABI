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
    public partial class frmConsultationClient : Form
    {


        private Client ceClient;

       

        public frmConsultationClient( Client unClient)
       // public frmConsultationClient()
        {
            ceClient = unClient;
            InitializeComponent();
           
        }

        private void frmConsultationClient_Load(object sender, EventArgs e)
        {
            this.afficheClient(this.ceClient);
        }




        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close(); // ferme ce form      

        }

        public void btnModifierClient_Click(object sender, EventArgs e)
        {
            frmModifClient  frmModif = new frmModifClient(ceClient);
            // afficher le form détail en modal
            frmModif.ShowDialog();

            if (frmModif.ShowDialog() == DialogResult.OK)
            {

                this.afficheClient(this.ceClient);
            }
            

        }

       
      

        private void afficheClient(Client leClient)
        {
            // affecter les labels
           
            this.lblSaisieTelephone.Text =ceClient.Tel.ToString();
            this.lblSaisieVille.Text = ceClient.Ville;
            this.lblSaisieAdresse.Text =ceClient.Adresse;
            this.lblSaisieRaisonSociale.Text =ceClient.Rs;
            this.lblSaisieNumeroClient.Text = ceClient.Num.ToString();
            this.lblSaisieCp.Text = ceClient.Cp.ToString();


        }

        private void btnNouveauContact_Click(object sender, EventArgs e)
        {
           
                frmNouveauContact frmCont = new frmNouveauContact();
                // afficher le form détail en modal
                frmCont.ShowDialog();
            
        }
    }
}
