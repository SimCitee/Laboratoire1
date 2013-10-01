using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire1
{
    class DeviseUSD : Devise
    {

        //Construit la classe avec le constructeur parent
        public DeviseUSD() : base(3, "Dollar américain", "$", "USD")
        {

        }

        public override decimal VersYEN(decimal montant)
        {
            return montant * 98.9549m;
        }
        public override decimal VersUSD(decimal montant)
        {
            return montant;
        }
        public override decimal VersCAD(decimal montant)
        {
            return montant * 1.0321m;
        }
        public override decimal VersEURO(decimal montant)
        {
            return montant * 0.7416m;
        }
    }
}
