using System;
using System.Collections.Generic;
using Head_First_Design_Patterns.Chapter_4___Factory_Pattern.Ingredients;

namespace Head_First_Design_Patterns.Chapter_4___Factory_Pattern.Pizzas
{
    public abstract class Pizza
    {
        protected string Name;
        protected Dough Dough;
        protected Sauce Sauce;
        protected Veggies[] Veggies;
        protected Cheese Cheese;
        protected Clams Clam;
        protected Pepperoni Pepperoni;
        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Baking for 25 minutes at 350°");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public string GetName()
        {
            return Name;
        }
    }
}