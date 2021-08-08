using System;

namespace Head_First_Design_Patterns.Chapter_1___Intro
{
    public abstract class Duck
    {
        protected IFlyBehaviour _flyBehaviour;
        protected IQuackBehaviour _quackBehaviour;
        
        public Duck() {}

        public abstract void Display();

        public void SetFlyBehaviour(IFlyBehaviour fb)
        {
            _flyBehaviour = fb;
        }

        public void SetQuackBehaviour(IQuackBehaviour qb)
        {
            _quackBehaviour = qb;
        }

        public void PerformFly()
        {
            _flyBehaviour.Fly();
        }

        public void PerformQuack()
        {
            _quackBehaviour.quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}