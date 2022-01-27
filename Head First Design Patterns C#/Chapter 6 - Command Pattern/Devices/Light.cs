using System;

namespace Head_First_Design_Patterns.Chapter_6___Command_Pattern.Devices
{
    public class Light
    {
        public void On()
        {
            Console.WriteLine("Light is on");
        }

        public void Off()
        {
            Console.WriteLine("Light is off");
        }
    }

    public class LightOnCommand : ICommand
    {
        private Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }
        
        public void Execute()
        {
            _light.On();
        }
    }
    
    public class LightOffCommand : ICommand
    {
        private Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }
        
        public void Execute()
        {
            _light.Off();
        }
    }
}