﻿using System;
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
    public partial class frmNewClient : Form
    {
        public frmNewClient()
        {
            

            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void frmNewClient_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
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
                txbCodePostal.Focus();
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
            if (!(estEntier(this.txbNumeroClient.Text)))
            {
                // la chaîne reçue n'est pas convertible
                code = false;
                System.Windows.Forms.MessageBox.Show("le numero client saisi n'est pas un entier valide", "ERREUR", MessageBoxButtons.OK);
            }

            if (!(estEntier(this.txbCodePostal.Text)))
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
                int Num = Int32.Parse(txbNumeroClient.Text.Trim());
                // pas de contrôle
                String Rs = txbRaisonSociale.Text;
                // avec conversion en MAJ
               String Ad = txbAdresse1.Text;
                String Ad2 = txbAdresse2.Text;
                // avec conversion en MAJ
                String Ville = txbVille.Text;
                // avec controle de saisie
                String Cp = txbCodePostal.Text.Trim();
                //ajouter la référence d'objet Client dans la collection
                String Tel = txbTelephone.Text.Trim();
                //ajouter la référence d'objet Client dans la collection

                Client nouveauClient = new Client(Num,Rs,Ad,Ad2,Cp,Ville,Tel);

                Donnees.ArrayClient.Add(nouveauClient);
                nouveauClient = null;
                return true;
            }
            catch (Exception ex)
            {
                
                System.Windows.Forms.MessageBox.Show("Erreur : \n" + ex.Message, "Ajout de Client");
                return false;
            }
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            frmNouveauContact frmCont = new frmNouveauContact();
            // afficher le form détail en modal
            frmCont.ShowDialog();
        }
    }
}
