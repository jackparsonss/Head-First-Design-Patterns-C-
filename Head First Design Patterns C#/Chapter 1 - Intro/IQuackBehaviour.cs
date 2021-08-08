using System;

namespace Head_First_Design_Patterns.Chapter_1___Intro
{
    public interface IQuackBehaviour
    {
        public void quack();
    }

    public class Quack : IQuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("Quack");
        }
    }

    public class MuteQuack : IQuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("...silence");
        }
    }

    public class Squeak : IQuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}