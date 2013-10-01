using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire1
{
    /**
     * 
     * Moule de base pour créer des devises
     * 
     */
    public abstract class Devise
    {
        private int id;

        public int Id
        {
            get
            {
                return id;
            }
        }

        private string description;

        public string Description
        {
            get
            {
                return description;
            }
        }

        private string symbole;     //Un symbole monétaire (peu avoir plus qu'un caractère)
        public string Symbole
        {
            get
            {
                return symbole;
            }
        }

        private string valeur;      //Ex CAD, USD, etc.
        public string Valeur
        {
            get
            {
                return valeur;
            }
        }

        protected Devise(int id, string description, string symbole, string valeur)
        {
            this.id = id;
            this.description = description;
            this.symbole = symbole;
            this.valeur = valeur;
        }

        //Retourne un dictionnaire (index, valeur) qui représente les noms de devises du système
        public static Dictionary<string, string> getListeDevises()
        {
            Dictionary<string, string> dictDevise = new Dictionary<string, string>();
            dictDevise.Add("1", "CAD");
            dictDevise.Add("2", "EURO");
            dictDevise.Add("3", "USD");
            dictDevise.Add("4", "YEN");

            return dictDevise;
        }

        public abstract decimal VersYEN(decimal montant);
        public abstract decimal VersUSD(decimal montant);
        public abstract decimal VersCAD(decimal montant);
        public abstract decimal VersEURO(decimal montant);

    }
}
