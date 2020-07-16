using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    interface IWorker
    {
        string GetMenuRow();
        bool CanRun(string userCommand);
        string Run(string userCommand, ref bool isExit, Team team, ProjectOfHouse projectOfHouse);
    }
}