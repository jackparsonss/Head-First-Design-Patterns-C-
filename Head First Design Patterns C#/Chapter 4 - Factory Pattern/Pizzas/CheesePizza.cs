using System;
using Head_First_Design_Patterns.Chapter_4___Factory_Pattern.Ingredients;

namespace Head_First_Design_Patterns.Chapter_4___Factory_Pattern.Pizzas
{
    public class CheesePizza : Pizza
    {
        private IPizzaIngredientFactory _ingredientFactory;
        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing" + Name);
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();
        }
    }
}