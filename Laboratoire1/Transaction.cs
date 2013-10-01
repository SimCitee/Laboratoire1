using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire1
{
    class Transaction
    {
        private int id;
        private static int compteurId;
        private DateTime date;
        private decimal montant;
        private int sousCategorieId;
        private int deviseId;
        private string description;
    }
}