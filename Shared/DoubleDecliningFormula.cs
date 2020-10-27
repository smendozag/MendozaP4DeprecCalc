using System;
using System.Collections.Generic;
using System.Text;

namespace MendozaP4DeprecCalc.Shared
{
    public class DoubleDecliningFormula : Values
    {
        //public decimal startingVal;
        //public decimal salvageVal;
        //public int lifeTime;
        //public int ageOfAsset;
        //public decimal result;

        DoubleDecliningFormula()
        {

        }
        private void Calc()
        {
            decimal depriciatedAssetCost = startingVal - salvageVal;
            double depRate = 1 / lifeTime;
            //result = Convert.ToDecimal(depRate) * depriciatedAssetCost;
            Result = 2 * Convert.ToDecimal(depRate) * startingVal;

        }
    }
}
