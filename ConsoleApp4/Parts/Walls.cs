using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Walls: IPart
    {
        public Walls()
        {
            description = "Стена";
        }

        public override string GetDescription()
        {
            return description;
        }

    }
}
