using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MendozaP4DeprecCalc.Shared
{
    public class AssetsTable
    {
        //public List<Values> Assets { get; set; } = new List<Values>();
        public List<int> Assets { get; set; } = new List<int>();

        public bool HasBeenAdded { get; set; } = false;
 
        public void Add(int assetId)
        {
            //var query = Assets.Select((asset, index) => new {index, asset.LifeTime });
            Assets.Add(assetId);

        }
        public void RemoveAt(int index)
        {
            Assets.RemoveAt(index);
        }





        //public void Add(Values asset)
        //{


        //    //var query = Assets.Select((asset, index) => new {index, asset.LifeTime });
        //    Assets.Add(asset);
        //}
        //public void RemoveAt(int assetIndex)
        //{
        //    Assets.RemoveAt(assetIndex);
        //}
        //public void Remove(Values asset)
        //{
        //    Assets.Remove(asset);
        //}

    }
}
