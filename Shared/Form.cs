using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MendozaP4DeprecCalc.Shared
{
    public class Form
    {
        public List<Values> Values { get; set; } = new List<Values>();

        public Values GetValues(int id)
        {
            return Values.SingleOrDefault(p => p.Id == id);

        }

    }
}
