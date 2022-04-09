using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWebServices
{
    internal class Utilisateur
    {

        public int id;

        public string nom;
        public  string prenom;
        public string telephone;
        public  string email;
        public string role;

        public string adresse;
       // public Boolean role;
        public string login;
        public string pwd;

        public Utilisateur()
        {
            
        }

        public Utilisateur(int id)
        {
            this.id = id;
        }

        public Utilisateur(string login, string pwd)
        {
            this.login = login;
            this.pwd = pwd;
        }

        public Utilisateur(string nom, string prenom, string telephone, string email, string adresse, string role, string login, string pwd)
        {

            this.nom = nom;
            this.prenom = prenom;
            this.telephone = telephone;
            this.email = email;
            this.adresse = adresse;
            this.role = role;
            this.login = login;
            this.pwd = pwd;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Email { get => email; set => email = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Role { get => role; set => role = value; }
        public string Login { get => login; set => login = value; }
        public string Pwd { get => pwd; set => pwd = value; }
       
    }
}
