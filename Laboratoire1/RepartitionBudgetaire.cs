using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire1
{
    public class RepartitionBudgetaire
    {
        #region "attributs"

        private int idSousCategorie;
        private decimal montant;
        private int annee;
        private int mois;

        #endregion

        public RepartitionBudgetaire(int idSousCat, int annee, int mois, decimal mnt)
        {
            this.idSousCategorie = idSousCat;
            this.annee = annee;
            this.mois = mois;
            this.montant = mnt;
        }

        public int IdSousCategorie
        {
            get { return idSousCategorie; }
            set { idSousCategorie = value; }
        }

        public decimal Montant
        {
            get { return montant; }
            set { montant = value; }
        }

        public int Annee
        {
            get { return annee; }
            set { annee = value; }
        }

        public int Mois
        {
            get { return mois; }
            set { mois = value; }
        }
    }
}
