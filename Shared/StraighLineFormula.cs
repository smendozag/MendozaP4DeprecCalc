using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace MendozaP4DeprecCalc.Shared
{
    public class StraighLineFormula : Values
    {

       
        public StraighLineFormula():base(1, 100M, 10M, 10, 2)
        {

        }
        public override void Calc()
        {
            decimal depriciatedAssetCost =  startingVal - salvageVal;
            double depRate = 1 / lifeTime;
            Result = Convert.ToDecimal(depRate) * depriciatedAssetCost;
        }
    }


    
}
