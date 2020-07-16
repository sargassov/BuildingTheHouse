using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Team
    {
        ProjectOfHouse projectOfHouse;
        public static int count;
        public Team(ProjectOfHouse project)
        {
            projectOfHouse = project;
            count = 0;

        }
        
        public void Construct()
        {
            if (count == 0) projectOfHouse.ProjectOfBasement();
            if (count == 1) projectOfHouse.ProjectOfWall();
            if (count == 2) projectOfHouse.ProjectOfWindow();
            if (count == 3) projectOfHouse.ProjectOfDoor();
            if (count == 4) projectOfHouse.ProjectOfRoof();

            count++;
        }
    }
}
