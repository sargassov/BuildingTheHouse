using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Basement : IPart
    {
        public Basement()
        {
            description = "Фундамент";
        }

        public override string GetDescription()
        {
            return description;
        }

    }
}
