using System;
using System.Collections.Generic;
using System.Text;

namespace MendozaP4DeprecCalc.Shared
{
    public class DoubleDecliningFormula : Values
    {

        public DoubleDecliningFormula():base(1, 100M, 10M, 10, 2)
        {

        }
        public override void Calc()
        {
            decimal depriciatedAssetCost = startingVal - salvageVal;
            double depRate = 1 / lifeTime;
            //result = Convert.ToDecimal(depRate) * depriciatedAssetCost;
            Result = 2 * Convert.ToDecimal(depRate) * startingVal;

        }
    }
}
