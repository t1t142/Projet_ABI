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
    public partial class frmPrincipal : Form
    {
        private frmPrincipal frmPrinc;
        private frmModifClient frmModifCli;
        private frmConsultationClient frmConsultationCli;
        private frmNewClient frmNouveauCli;
        private frmNouveauContact  frmNouveauCont;
        private frmlistClient frmlistCli;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            // déclare une instance du form principal  
            frmlistCli = new frmlistClient();
            // instancie le form principal 
            frmlistCli.MdiParent = this;
            // précise le conteneur MDI du form principal 
            frmlistCli.Show();
            // affiche le form (dans son form conteneur) 
        }

       private void visualiserToolStripMenuItem_Click(object sender, EventArgs e)
        {


           if (this.frmConsultationCli == null) // le form secondaire n'est pas affiché ==> l'instancier            
           {
                Client leClient = Donnees.ArrayClient[0] as Client;
                this.frmConsultationCli = new frmConsultationClient(leClient); // instancie le form                 
                                                             // implémente un événement sur le nouveau form                  
                                                             // pour libérer la ref à ce form               
                this.frmConsultationCli.FormClosing += new FormClosingEventHandler(this.fermeConsult);
                this.frmConsultationCli.Show();
             }
            else // le form secondaire est affiché 
            {
                this.frmConsultationCli.Activate(); // réactive le form (lui donne le focus) 
            }

        }
        private void nouveauClientToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (this.frmNouveauCli == null) // le form secondaire n'est pas affiché ==> l'instancier            
            {
                this.frmNouveauCli = new frmNewClient(); // instancie le form                 
                                                                       // implémente un événement sur le nouveau form                  
                                                                       // pour libérer la ref à ce form               
                this.frmNouveauCli.FormClosing += new FormClosingEventHandler(this.fermeNew);
                

                this.frmNouveauCli.Show();
            }
            else // le form secondaire est affiché 
            {
                this.frmNouveauCli.Activate(); // réactive le form (lui donne le focus) 
            } 
        }
        public void fermeConsult(object sender, EventArgs e)
        {
            this.frmConsultationCli = null; // libère la réf au from chrono  

        }
        public void fermeNew(object sender, EventArgs e)
        {
            this.frmNouveauCli = null; // libère la réf au from chrono  

        }

        public void fermeList(object sender, EventArgs e)
        {
            this.frmlistCli = null; // libère la réf au from chrono  

        }


        private void listClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.frmlistCli == null) // le form secondaire n'est pas affiché ==> l'instancier            
            {
                this.frmlistCli = new frmlistClient(); // instancie le form                 
                                                                       // implémente un événement sur le nouveau form                  
                                                                       // pour libérer la ref à ce form               
                this.frmlistCli.FormClosing += new FormClosingEventHandler(this.fermeList);
                //this.frmNouveauCli.btnModifierClient.Click += new EventHandler(this.test);

                this.frmlistCli.Show();
            }
            else // le form secondaire est affiché 
            {
                this.frmlistCli.Activate(); // réactive le form (lui donne le focus) 
            }

        }
    }
}
