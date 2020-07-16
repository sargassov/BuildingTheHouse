using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class ConcreteHouse : ProjectOfHouse
    {
        HouseProduct house = new HouseProduct();
        public override void ProjectOfBasement() { house.Add(new Basement());}
        public override void ProjectOfRoof() { house.Add(new Roof()); }
        public override void ProjectOfDoor() { house.Add(new Door()); }
        public override void ProjectOfWall() { for (short x = 0; x < 4; x++) { house.Add(new Walls()); }}
        public override void ProjectOfWindow() { for (short x = 0; x < 4; x++) { house.Add(new Window()); } } 
        public override HouseProduct GetHouse()
        {
            return house;
        }
    }
}
