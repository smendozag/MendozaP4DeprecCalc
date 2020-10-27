using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MendozaP4DeprecCalc.Shared
{
    class AssetTable
    {
        public List<int> 
            { get; set; } = new List<int>();

        public void Add(int assetId)
        {
            Assets.Add(assetId);
        }
        public void RemoveAt(int assetIndex)
        {
            Assets.RemoveAt(assetIndex);
        }


    }
}
