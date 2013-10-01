using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Laboratoire1
{
    public partial class frmLogin : Form
    {
        private Global globalRef;               //Référence à la classe de variables globales
        private List<Profile> nouveauProfils = new List<Profile>();  //Contient les nouveau profils qui on été crée (patch, car on ne le garde pas dans le fichier

        public frmLogin(Global global)
        {
            InitializeComponent();

            this.globalRef = global;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dDevise.DropDownStyle = ComboBoxStyle.DropDownList; //Empèche d'entrer du texte dans le dropdown

            MettreProfilsEnMemoire();

            CreerListeProfiles();

            CreerListeDevises();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lUtilisateur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        //Login
        private void bLogin_Click(object sender, EventArgs e)
        {
 
            //Valeur sélectionnée de la liste des profils
            string nomUtilisateur = lUtilisateur.GetItemText(lUtilisateur.SelectedItem);

            if (nomUtilisateur == "")
            {
                MessageBox.Show("Veuillez sélectionner un profil!");
            }
            else
            {

                foreach (Profile p in nouveauProfils)
                {
                    if (p.NomUtilisateur == nomUtilisateur)
                    {
                        //Rend le profil accessible à toute l'application
                        this.globalRef.Profile = p;

                        //Ferme le formulaire
                        this.Close();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profile p = new Profile("Roy", "Jean", "jroy", 1);
            //Crée le user
            this.globalRef.Profile = p;

            //Ferme le formulaire
            this.Close();
        }

        //Emplit la liste des profiles
        private void CreerListeProfiles()
        {
            //Emplit la liste des utilisateurs
            foreach (Profile p in nouveauProfils)
            {
                lUtilisateur.Items.Add(p.NomUtilisateur);
            }
        }

        private void lUtilisateur_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        //Supprime un profil
        private void bSupprimer_Click(object sender, EventArgs e)
        {
            //Valeur sélectionnée de la liste des profils
            string nomUtilisateur = lUtilisateur.GetItemText(lUtilisateur.SelectedItem);

            if(nomUtilisateur == "")
            {
                MessageBox.Show("Veuillez sélectionner un profil!");
            }
            else
            {

                //Efface le profil de la liste
                lUtilisateur.Items.Remove(nomUtilisateur);

                
                //Enlève le profil de la mémoire
                foreach (Profile p in this.nouveauProfils)
                {
                    if (p.NomUtilisateur == nomUtilisateur)
                    {
                        //Rend le profil accessible à toute l'application
                        nouveauProfils.Remove(p);
                        break;

                 
                    }
                }
            
            }
        }

        //Crée la liste des devises pour la création d'un prfil
        private void CreerListeDevises()
        {
            //Crée un dictionnaire de devises pour les ajouter au dropdown
            Dictionary<string, string> dictDevise = Devise.getListeDevises();


            dDevise.DataSource = new BindingSource(dictDevise, null);
            dDevise.DisplayMember = "Value";
            dDevise.ValueMember = "Key";

           
        }

        private void bCreerUtilisateur_Click(object sender, EventArgs e)
        {
            Profile p;
            //Vérifie si les données sont valides
            if(validerAjoutUtilisateur())
            {
                p = new Profile(tNom.Text, tPrenom.Text, tNomUtilisateur.Text, dDevise.SelectedIndex);
               
                //Garde le profil crée en mémoire
                this.nouveauProfils.Add(p);
                
                //Ajoute le profil à la liste
                lUtilisateur.Items.Add(p.NomUtilisateur);

                //Vide les champs
                viderChampsNouvelUtilisateur();
            }


        }

        private bool validerAjoutUtilisateur()
        {
            bool donneesValide = false;
            if(tNom.Text =="")
            {
                MessageBox.Show("Vous devez entrer un nom!");

            }
            else if(tPrenom.Text == "")
            {
                MessageBox.Show("Vous devez entrer un prénom!");
            }
            else if(tNomUtilisateur.Text == "")
            {
                MessageBox.Show("Vous devez entrer un nom d'utilisateur!");
            }
            else if (dDevise.Text == "")
            {
                MessageBox.Show("Vous devez sélectionner une devise!");
            }
            else
            {
                //Test que le nom d'utilisateur n'est pas déjà existant
                if(lUtilisateur.Items.Contains(tNomUtilisateur.Text))
                {
                    MessageBox.Show("Cet utilisateur existe déjà!");
                }
                else
                {
                    donneesValide = true;
                }
                
            }
            
            

            return donneesValide;
        }

        //Vide les champs de création d'un nouvel utilisateur
        private void viderChampsNouvelUtilisateur()
        {
            tPrenom.Text = "";
            tPrenom.Text = "";
            tNomUtilisateur.Text = "";
            
        }

        //Charle les profils du fichier en mémoire
        private void MettreProfilsEnMemoire()
        {
            string[] profileArray;
            string fichierProfile = "profile.csv";
            Profile profile;

            try
            {

                using (StreamReader sr = new StreamReader(fichierProfile))
                {
                    String ligne;

                    //Lecture des lignes du fichier
                    while ((ligne = sr.ReadLine()) != null)
                    {

                        profileArray = ligne.Split(',');

                        //Met le profil en mémoire
                        profile = new Profile(profileArray[1], profileArray[2], profileArray[3], int.Parse(profileArray[4]), 
                                              int.Parse(profileArray[0]));

                         this.nouveauProfils.Add(profile);

                    }


                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Le fichier de profile '" + fichierProfile + "' est introuvable!");
                System.Console.WriteLine(e.Message);

            }
        }

        
    }
}
