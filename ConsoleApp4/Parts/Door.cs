using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Door:IPart
    {
        public Door()
        {
            description = "Дверь";
        }

        public override string GetDescription()
        {
            return description;
        }

    }
}
