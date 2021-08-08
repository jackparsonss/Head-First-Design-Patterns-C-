using System;

namespace Head_First_Design_Patterns.Chapter_1___Intro
{
    public interface IFlyBehaviour
    {
        public void Fly();
    }

    public class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!!");
        }
    }

    public class FlyNoWay : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly!!");
        }
    }

    public class FlyRocketPowered : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket!!");
        }
    }
}