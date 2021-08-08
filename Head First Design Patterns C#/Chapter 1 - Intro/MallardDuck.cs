using System;

namespace Head_First_Design_Patterns.Chapter_1___Intro
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            _flyBehaviour = new FlyWithWings();
            _quackBehaviour = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Mallard Duck!");
        }
    }
}