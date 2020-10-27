using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace MendozaP4DeprecCalc.Shared
{
    public class StraighLineFormula :Values
    {
        //public decimal startingVal;
        //public decimal salvageVal;
        //public int lifeTime;
        //public int ageOfAsset;
        //public decimal result;

        public StraighLineFormula()
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
