using System;
using System.Collections.Generic;
using System.Text;

namespace MendozaP4DeprecCalc.Shared
{
    public class Values 
    {

        public decimal startingVal;
        public decimal salvageVal;
        public int lifeTime;
        public int ageOfAsset;


        public decimal  Result{ get; set; }

        public decimal StartingVal 
        {
            get { return startingVal; }
            set { value = startingVal; Calc(); }
        }

        public decimal SalvageVal
        {
            get { return salvageVal; }
            set { value = salvageVal; Calc(); }
        }
    
        public int LifeTime
        {
            get { return lifeTime; }
            set { value = lifeTime; Calc(); }
        }
        public int AgeOfAsset
        {
            get { return ageOfAsset; }
            set { value = ageOfAsset; Calc(); }
        }


        Values(decimal startVal , decimal salvageVal, int lifeTime
            , int ageOfAsset)
        {
            this.StartingVal = startVal;
            this.SalvageVal = salvageVal;
            this.LifeTime = lifeTime;
            this.ageOfAsset = ageOfAsset;
        }

        public virtual void Calc()
        {
            Result = 1;
        }
    }
}
