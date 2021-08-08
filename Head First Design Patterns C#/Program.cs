using System;
using Head_First_Design_Patterns.Chapter_1___Intro;

namespace Head_First_Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Chapter1();
        }

        static void Chapter1()
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            Duck model = new ModelDuck();
            model.PerformFly();
            model.SetFlyBehaviour(new FlyRocketPowered());
            model.PerformFly();
        }
    }
}