using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class ExitCommand : IWorker
    {
        public bool CanRun(string userCommand)
        {
            return userCommand == "0";
        }
        public string GetMenuRow()
        {
            return "0. Выход";
        }

        public string Run(string userCommand, ref bool isExit, Team team, ProjectOfHouse projectOfHouse)
        {
            Console.WriteLine("\n");
            isExit = true;
            return "";
        }
    }
}