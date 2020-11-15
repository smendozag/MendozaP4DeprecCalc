using MendozaP4DeprecCalc.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MendozaP4DeprecCalc.Shared
{
    public class State
    {
        public  Form Form { get; set; } = new Form();
        public AssetsTable AssetsTable { get; set; } = new AssetsTable();
        public UI UI { get; set; } = new UI();
    }
}
