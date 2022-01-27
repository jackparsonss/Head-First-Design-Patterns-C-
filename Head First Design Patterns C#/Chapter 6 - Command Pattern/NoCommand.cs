using System;

namespace Head_First_Design_Patterns.Chapter_6___Command_Pattern
{
    public class NoCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("There is no command assigned");
        }
    }
}