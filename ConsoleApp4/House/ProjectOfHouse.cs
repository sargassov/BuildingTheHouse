using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    abstract class ProjectOfHouse
    {
        public abstract void ProjectOfBasement();
        public abstract void ProjectOfDoor();
        public abstract void ProjectOfRoof();
        public abstract void ProjectOfWall();
        public abstract void ProjectOfWindow();

        public abstract HouseProduct GetHouse();

    }
}
