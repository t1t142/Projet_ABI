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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmModifClient frmtest;
            // déclare une instance du form principal  
            frmtest = new frmModifClient();
        // instancie le form principal 
        frmtest.MdiParent = this;
            // précise le conteneur MDI du form principal 
            frmtest.Show();
            // affiche le form (dans son form conteneur) 
        }

    private void visualiserToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmConsultationClient frmtest2;
            frmtest2 = new frmConsultationClient();
            // instancie le form principal 
            frmtest2.MdiParent = this;
            // précise le conteneur MDI du form principal 
            frmtest2.Show();
            // affiche le form (dans son form conteneur) 
        }
    }
}
