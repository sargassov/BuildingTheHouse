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
    
    class Program
    {
        public static void Main()
        {

            ProjectOfHouse projectOfHouse = new ConcreteHouse();
            Team team = new Team(projectOfHouse);

            ArrayList commands = new ArrayList();
            commands.Add(new ExitCommand());
            commands.Add(new Worker());
            commands.Add(new TeamLeader());
            bool isComplete = false;
            string userCommand;
            do
            {
                WriteLine("");
                WriteLine("Меню строительства дома:");
                foreach (IWorker command in commands)
                {
                    WriteLine(command.GetMenuRow());
                }

                userCommand = ReadLine();

                foreach (IWorker command in commands)
                {
                    if (command.CanRun(userCommand))
                    {
                        WriteLine(command.Run(userCommand, ref isComplete, team, projectOfHouse));
                    }
                }

            } while (!isComplete);



            
            HouseProduct product = projectOfHouse.GetHouse();
        }
    }
}
