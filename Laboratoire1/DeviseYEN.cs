using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire1
{
    class DeviseYEN : Devise
    {
         //Construit la classe avec le constructeur parent
        public DeviseYEN() : base(4, "Yen", "¥", "YEN")
        {
            
        }

        public override decimal VersYEN(decimal montant)
        {
            return montant;
        }
        public override decimal VersUSD(decimal montant)
        {
            return montant * 0.01011m;
        }
        public override decimal VersCAD(decimal montant)
        {
            return montant * 0.01043m;
        }
        public override decimal VersEURO(decimal montant)
        {
            return montant * 0.007494m;
        }
    }
}
