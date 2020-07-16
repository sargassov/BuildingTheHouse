using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Roof : IPart
    {
        public Roof()
        {
            description = "Крыша";
        }

        public override string GetDescription()
        {
            return description;
        }

    }
}
