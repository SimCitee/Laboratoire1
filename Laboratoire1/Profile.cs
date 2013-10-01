using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Laboratoire1
{
   /**
    * Cette classe définit le profil d'un utilisateur de l'application   
    */
    public class Profile
    {
        
        private int id;
        private Budget budget;  // Budget associé au profile

        public Budget Budget
        {
            get { return budget; }
            set { budget = value; }
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        private static int idCompteur = 500;

        private string nom;  // Nom du profile
        public string Nom
        {
            get;
            set;
        }

        private string prenom;  // Prénom du profile
        public string Prenom
        {
            get;
            set;
        }

        private string nomUtilisateur;  // Username du profile
        public string NomUtilisateur
        {
            get;
            set;
        }

        private int idDevisePref;  // Id de la devise préférée du profile

        ///private Devise devisePref;    //Devise préféré de l'utilisateur

        //private Transactions transactions[];  // Tableau des transactions de l'utilisateur

        //Construit le profile à partir d'un fichier (id du profile)
        public Profile(int idProfile)
        {

            CreerProfileDepuisFichier(idProfile);
            this.budget = new Budget(idProfile);

        }

        public Profile(string nom, string prenom, string nomUtilisateur, int idDevisePref)
        {
            this.id = idCompteur++;
            this.Nom = nom;
            this.Prenom = prenom;
            this.NomUtilisateur = nomUtilisateur;
            this.idDevisePref = idDevisePref;
            this.budget = new Budget(id);



            //Initialise la devise préférée




        }

        //Construit le profile à partir de nouvelles information
        public Profile(string nom, string prenom, string nomUtilisateur, int idDevisePref, int id)
        {
            this.id = id; 
            this.Nom = nom;
            this.Prenom = prenom;
            this.NomUtilisateur = nomUtilisateur;
            this.idDevisePref = idDevisePref;
            this.budget = new Budget(id);

            //Initialise la devise préférée




        }

        

        //Crée un utilisateur à partir des infos contenues dans un fichier texte
        private void CreerProfileDepuisFichier(int idProfile)
        {
            try
            {
                using (StreamReader sr = new StreamReader("profile.csv"))
                {
                    String ligne;
                    
                    //Lecture des lignes du fichier pour trouver le bon profil
                    while ((ligne = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(ligne);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("Le fichier de profile 'profile.csv' est introuvable!");
                Console.WriteLine(e.Message);
            }
        }

        private void CreerRepartitionDepuisFichier(int idProfile)
        {
            try
            {
                using (StreamReader sr = new StreamReader("repartitionBudgetaire.csv"))
                {
                    String ligne;

                    //Lecture des lignes du fichier pour trouver le bon profil
                    while ((ligne = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(ligne);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("Le fichier de profile 'profile.csv' est introuvable!");
                Console.WriteLine(e.Message);
            }
        }


        public override string ToString()
        {

            return  "ID : " + this.Id + 
                    "\nNom : " + this.Nom + 
                    "\nPrenom : " + this.Prenom + 
                    "\nNomUtilisateur : " + this.NomUtilisateur + "\n";
        }
    }
}
