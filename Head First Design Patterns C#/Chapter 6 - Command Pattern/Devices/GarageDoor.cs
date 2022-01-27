using System;

namespace Head_First_Design_Patterns.Chapter_6___Command_Pattern.Devices
{
    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Garage Door is open");
        }

        public void Down()
        {
            Console.WriteLine("Garage Door is down");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped opening Garage Door");
        }

        public void LightOn()
        {
            Console.WriteLine("Garage light is on");
        }

        public void LightOff()
        {
            Console.WriteLine("Garage light is off");
        }
    }

    public class GarageDoorOpenCommand : ICommand
    {
        private GarageDoor _garageDoor;

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.Up();
        }
    }
}