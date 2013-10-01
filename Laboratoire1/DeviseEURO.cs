using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire1
{
    class DeviseEURO : Devise
    {
        //Construit la classe avec le constructeur parent
        public DeviseEURO() : base(2, "Euro", "€", "EURO")
        {
            
        }

        public override decimal VersYEN(decimal montant)
        {
            return montant * 133.4324m;
        }
        public override decimal VersUSD(decimal montant)
        {
            return montant * 1.3484m;
        }
        public override decimal VersCAD(decimal montant)
        {
            return montant * 1.3917m;
        }
        public override decimal VersEURO(decimal montant)
        {
            return montant;
        }
    }
}
