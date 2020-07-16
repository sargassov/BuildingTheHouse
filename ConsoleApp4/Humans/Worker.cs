using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Worker : IWorker
    {
        public bool CanRun(string userCommand)
        {
            return userCommand == "1";
        }

        public string GetMenuRow()
        {
            return "1. Отправить рабочих на строительство следующей части";
        }

        public string Run(string userCommand, ref bool isExit, Team team, ProjectOfHouse projectOfHouse)
        {

            if (Team.count != 5) { team.Construct(); return "Следующая часть дома достроена"; }
            else return "Дом построен";
            
        }
    }
}
