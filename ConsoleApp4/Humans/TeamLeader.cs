using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class TeamLeader : IWorker
    {
        public bool CanRun(string userCommand)
        {
            return userCommand == "2";
        }

        public string GetMenuRow()
        {
            return "2. Вызвать прораба";
        }

        public string Run(string userCommand, ref bool isExit, Team team, ProjectOfHouse projectOfHouse)
        {
            HouseProduct product = projectOfHouse.GetHouse();
            if (product.house.Count == 0) Console.WriteLine("\nСтроительство еще не начинали:");
            else if (Team.count == 5) Console.WriteLine("\nДом построен:");
            else Console.WriteLine("\nЧасти дома, которые уже готовы:");
            for (short x = 0; x<product.house.Count; x++)
            {
                Console.WriteLine((x+1) + " " + product.house[x].GetDescription());
            }
            return "Отчет о стройке составлен";
        }
    }
}
