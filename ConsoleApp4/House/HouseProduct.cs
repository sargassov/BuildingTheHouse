using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp4
{
    class HouseProduct
    {
        public List<IPart> house = new List<IPart>();
        public void Add(IPart part)
        {
            house.Add(part);
        }
    }
}
