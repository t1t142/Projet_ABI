using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_ABI
{
   public class Client
    {
        private int num;
        private String rs;
        private String adresse;
        private String adresse2;
        private String cp;
        private String ville;
        private String tel;
        private int ca;
        private int effectif;
        private  List <Contact> contact;

        public int Num { get => num; set => num = value; }
        public string Rs { get => rs; set => rs = value; }
        public string Adresse { get => adresse; set => adresse = value.Trim().ToUpper(); }
        public string Adresse2 { get => adresse2; set => adresse2 = value.Trim().ToUpper(); }
        public string Cp
        {
            get => cp;

            set
            {             // l'appelant doit fournir un code postal valide à 5 chiffres 
                Int32 i;
                // variable de boucle            
                Boolean erreur = false;
                // indicateur erreur            
                if (value.Length == 5)
                // 5 car. attendus : OK ==> contrôler un à un             
                {
                    for (i = 0; i < value.Length; i++)
                    // controle chiffres par boucle  
                    {
                        if (!(Char.IsDigit(value[i])))
                        // charabia ??                         
                        { erreur = true; }
                    } // fin de boucle controle chiffres               
                    if (erreur) //on a rencontre un non-chiffre                 
                    {
                        // première solution par simple messagebox                
                        System.Windows.Forms.MessageBox.Show(value.ToString() + "\n" + "n'est pas un code postal valide : uniquement des chiffres", "Erreur Classe MStagiaire", System.Windows.Forms.MessageBoxButtons.OK);
                    }
                    else
                    {
                        cp = value;
                        // tout est bon, on affecte la propriété              
                    }
                }
                else // il n'y a pas 5 caractères            
                {
                    // première solution par simple messagebox  
                    System.Windows.Forms.MessageBox.Show(value.ToString() + "\n" + "n'est pas un code postal valide : 5 chiffres, pas plus, pas moins", "Erreur Classe MStagiaire", System.Windows.Forms.MessageBoxButtons.OK);
                }
            }
        }
        



        public string Ville { get => ville; set => ville = value.Trim().ToUpper(); }
        public string Tel { get => tel; set => tel = value; }

        public Client(int num, string rs, string adresse, string adresse2, string cp, string ville, string tel)
        {
            Num = num;
            Rs = rs;
            Adresse = adresse;
            Adresse2 = adresse2;
            Cp = cp;
            Ville = ville;
            Tel = tel;
        }
    }

}
