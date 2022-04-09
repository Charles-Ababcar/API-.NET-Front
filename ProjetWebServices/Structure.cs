using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWebServices
{
    internal class Structure
    {
        public Structure()
        {
        }

        public Structure(int idStructure)
        {
            this.idStructure = idStructure;
        }

        public Structure(int idStructure ,string nom, string adresse, string contact, string capacite, int nbresplaces, int nombredoses)
        {
            this.idStructure = idStructure;
            this.nom = nom;
            this.adresse = adresse;
            this.contact = contact;
            this.capacite = capacite;
            this.nbresplaces = nbresplaces;
            this.nombredoses = nombredoses;
        }
        public int idStructure { get; set; }
        public string nom { get; set; }
        public string adresse { get; set; }
        public string contact { get; set; }
        public string capacite { get; set; }
        public int  nbresplaces { get; set; }
        public int nombredoses { get; set; }
        //public string capaciteAccueil { get; set; }
       
    }
}
