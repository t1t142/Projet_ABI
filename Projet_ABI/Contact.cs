using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_ABI
{
   public class Contact
    {

        private int num;
        private String nom;
        private String prenom;
        private String fonction;
        private String email;
        private String tel;

        public int Num { get => num; set => num = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom {

            get => prenom;
            set {

                if (value == "")
                {

                }

                else
                {

                    prenom = value;

                }


               
            }
        }
        public string Fonction { get => fonction; set => fonction = value; }
        public string Email { get => email; set => email = value; }
        public string Tel { get => tel; set => tel = value; }

        public Contact(int num, string nom, string prenom, string fonction, string email)
        {
            Num = num;
            Nom = nom;
            Prenom = prenom;
            Fonction = fonction;
            Email = email;
        }
    }
}
