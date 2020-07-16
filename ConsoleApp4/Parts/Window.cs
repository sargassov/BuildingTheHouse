using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Window: IPart
    {
        public Window()
        {
            description = "Окно";
        }

        public override string GetDescription()
        {
            return description;
        }

    }
}
