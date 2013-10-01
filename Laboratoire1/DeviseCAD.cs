using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire1
{
    class DeviseCAD : Devise
    {

        //Construit la classe avec le constructeur parent
        public DeviseCAD() : base(1, "Dollar canadien", "$", "CAD")
        {
            
        }

        public override decimal VersYEN(decimal montant)
        {
            return montant * 95.8773m;
        }
        public override decimal VersUSD(decimal montant)
        {
            return montant * 0.9689m;
        }
        public override decimal VersCAD(decimal montant)
        {
            return montant;
        }
        public override decimal VersEURO(decimal montant)
        {
            return montant * 0.7185m;
        }
    }
}
