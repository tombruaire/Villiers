using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villiers
{
    class Utilisateurs
    {

        private int id;
        public int Id
        {
            get
            {
                return id;
            }
        }

        private string nom;
        public string Nom
        {
            get
            {
                return nom;
            }
            set
            {
                nom = value;
            }
        }

        private string prenom;
        public string Prenom
        {
            get
            {
                return prenom;
            }
            set
            {
                prenom = value;
            }
        }

        private string pseudo;
        public string Pseudo
        {
            get
            {
                return pseudo;
            }
            set
            {
                pseudo = value;
            }
        }

        private string email;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        private DateTime date_inscription;
        public DateTime Date_inscription
        {
            get
            {
                return date_inscription;
            }
        }

        public Utilisateurs(int id, string nom, string prenom, string pseudo, string email, DateTime date_inscription)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.pseudo = pseudo;
            this.email = email;
            this.date_inscription = date_inscription;
        }

    }
}
