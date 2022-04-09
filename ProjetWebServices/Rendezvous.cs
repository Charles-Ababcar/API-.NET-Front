using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWebServices
{
    internal class Rendezvous
    {
        public int idRv;
        public  string libelle;
        public DateTime dateRv;
        public string type;
        public Structure structure;
        public  Utilisateur utilisateur;
        private string da;
        private int idStructure;
        private int id;
        private string dateRv1;

        public int IdRv { get => idRv; set => idRv = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public DateTime DateRv { get => dateRv; set => dateRv = value; }
        public string Type { get => type; set => type = value; }
        internal Structure Structure { get => structure; set => structure = value; }
        internal Utilisateur Utilisateur { get => utilisateur; set => utilisateur = value; }

        public Rendezvous(string l)
        {

        }
    public Rendezvous(int idRv, string libelle, DateTime dateRv, string type,Structure structure,Utilisateur utilisateur)
    {
        this.IdRv = idRv;
        this.Libelle = libelle;
        this.DateRv = dateRv;
        this.Type = type;
        this.Structure = structure;
        this.Utilisateur = utilisateur;
           
    }
        public Rendezvous( string libelle, DateTime dateRv, string type, Structure structure, Utilisateur utilisateur)
        {
           
            this.Libelle = libelle;
            this.DateRv = dateRv;
            this.Type = type;
            this.Structure = structure;
            this.Utilisateur = utilisateur;

        }

    
    }
}
