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
    public class Budget
    {
        private List<RepartitionBudgetaire> repartitions = new List<RepartitionBudgetaire>();

        public Budget(int idProfile)
        {
            ChargerRepartition(idProfile);
        }

        public List<RepartitionBudgetaire> Repartitions
        {
            get { return repartitions; }
            set { repartitions = value; }
        }

        public void AjouterRepartitionBudgetaire(RepartitionBudgetaire repartition)
        {
            this.repartitions.Add(repartition);
        }

        public float RetournerBudget(bool bEnArgent = false)
        {
            return 2;
        }

        public float RetournerBudget(int moisDebut, int moisFin, bool bEnArgent = false)
        {
            return 2;
        }

        public override string ToString()
        {
            return repartitions.ToString();
        }

        private Array CalculerBudgetPourcent(int moisDebut, int moisFin)
        {
            int[,] multiDimensionalArray1 = new int[2, 3];
            return multiDimensionalArray1;
        }

        private Array CalculerBudgetArgent(int moisDebut, int moisFin)
        {
            int[,] multiDimensionalArray1 = new int[2, 3];
            return multiDimensionalArray1;
        }

        public void AjusterBudget()
        {

        }

        private void ChargerRepartition(int idProfile)
        {
            string[] repartitionArray;
            string fichierRepartition = "repartitionBudgetaire.csv";

            try
            {

                using (StreamReader sr = new StreamReader(@"..\..\" + fichierRepartition))
                {
                    String ligne;

                    //lecture du fichier
                    while ((ligne = sr.ReadLine()) != null)
                    {

                        repartitionArray = ligne.Split(',');

                        // ajouter la répartition seulement si = à profile courant
                        if (repartitionArray[0] == idProfile.ToString())
                        {
                            //Met la repartition en memoire
                            RepartitionBudgetaire rep = new RepartitionBudgetaire(int.Parse(repartitionArray[2]), int.Parse(repartitionArray[3]), 
                                                            int.Parse(repartitionArray[4]), decimal.Parse(repartitionArray[5]));

                            this.repartitions.Add(rep);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Le fichier de répartitions '" + fichierRepartition + "' est introuvable.");
                System.Console.WriteLine(e.Message);
            }
        }

        private void AjouterRepartition(RepartitionBudgetaire rep)
        {
            this.repartitions.Add(rep);
        }


    }
}
