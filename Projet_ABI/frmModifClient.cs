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
    public partial class frmModifClient : Form
    {


        private Client ceClient;




            public frmModifClient(Client unClient)
        {




                ceClient = unClient;


                InitializeComponent();
            // comboBox1.Items.Add("Blue");
            //comboBox1.Items.Add("red");
        }

       
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close(); // ferme ce form      
        }


        private void afficheClient(Client leClient)
        {
            // affecter les labels

            this.txtTel.Text = ceClient.Tel.ToString();
            this.txtCp .Text = ceClient.Ville;
            this.txtAdresse.Text = ceClient.Adresse;
            this.txtVille.Text = ceClient.Cp;
            this.txtRs.Text = ceClient.Rs;
            this.label9.Text = ceClient.Num.ToString();



        }

        private void frmModifClient_Load(object sender, EventArgs e)
        {
            this.afficheClient(this.ceClient);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (controle())
            {

                //  MessageBox.Show("bon");

                if (instancie())
                {

                    this.DialogResult = DialogResult.OK;// fermeture de la boite de dialogue par validation
                }
            }

            else
            {
                // MessageBox.Show("enfin");
                // this.DialogResult = DialogResult.Abort ;
                txtVille.Focus();
            }
        }

        /// <summary>
        /// fonction de contrôle de vraissemblance des différents
        /// champs du form :
        /// (appelée avant d'instancier un objet MStagiaire
        /// et d'affecter ses membres)
        /// </summary>
        /// <returns>Booléen : true = OK, false = erreur</returns>
        private Boolean controle()
        {
            // contrôler la vraissemblance de tous les champs
            Boolean code = true; // le code de retour ; OK a priori
            // appel fonction générique de contrôle
            

            if (!(estEntier(this.txtVille.Text)))
            {
                code = false;
                System.Windows.Forms.MessageBox.Show("le code postal saisi n'est pas correct", "ERREUR", MessageBoxButtons.OK);
            }
            return code;
        }

        /// <summary>
        /// fonction générique de contrôle qu'une chaine reçue
        /// pourra se convertir en Int32
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private Boolean estEntier(String s)
        {
            /*vérifier que la chaine reçue représente bien un entier valide :
             * - uniquement des chiffres
             * - pas vide
             * - pas plus de 9 chiffres (capacité maxi du type Int32)
             */
            Int32 i;              // indice de parcours de chaîne
            Char c;               // caractère courant
            Boolean code = true; // code retour; OK a priori

            // test longueur chaîne reçue
            if (s.Length < 10 && s.Length > 0)
            {
                // vérifier 1 à 1 que tous les caractères sont des chiffres
                for (i = 0; i < s.Length; i++)
                {
                    c = s[i]; // extrait le i° car
                    if (!(Char.IsDigit(c))) // si ce n'est pas un chiffre
                    {
                        code = false; // erreur détectée
                    }

                }// fin de boucle for
            }
            else // erreur de longueur de chaine
            {
                code = false; // erreur détectée
            }

            return code;
        }

        /// <summary>
        /// fonction qui instancie un nouvel objet Client
        /// puis tente d'affecter ses membres (var. ou prop.)
        /// avec interception erreur éventuelle levée par la classe Client
        /// </summary>
        /// <returns>Boolean : true = OK, false = erreur</returns>
        private Boolean instancie()
        {
            // créer une référence d'objet Client

            try
            {
                //affecter les données de l'objet Client :
                // variables simples, ou propriétés
                // ce qui déclenche alors le code des méthodes set
                //
                // conversion numéro client saisi en textbox vers le type integer
                
               ceClient.Rs = txtRs.Text;
                // avec conversion en MAJ
                ceClient.Adresse = txtAdresse.Text;
                ceClient.Adresse2 = txtAdresse2.Text;
                // avec conversion en MAJ
                ceClient.Ville = txtCp.Text;
                // avec controle de saisie
                ceClient.Cp = txtVille.Text.Trim();
                //ajouter la référence d'objet Client dans la collection
                String Tel = txtTel.Text.Trim();
                //ajouter la référence d'objet Client dans la collection




                return true;
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Erreur : \n" + ex.Message, "Modification de Client");
                return false;
            }
        }

        private void txtVille_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
