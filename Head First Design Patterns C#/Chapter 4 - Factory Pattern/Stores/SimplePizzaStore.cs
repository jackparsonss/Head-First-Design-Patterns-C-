using Head_First_Design_Patterns.Chapter_4___Factory_Pattern.Ingredients;
using Head_First_Design_Patterns.Chapter_4___Factory_Pattern.Pizzas;

namespace Head_First_Design_Patterns.Chapter_4___Factory_Pattern.Stores
{
    public class SimplePizzaStore : PizzaStore
    {
        private IPizzaIngredientFactory _ingredientFactory = new SimplePizzaIngredientFactory();
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = type switch
            {
                "cheese" => new CheesePizza(_ingredientFactory),
                "pepperoni" => new PepperoniPizza(_ingredientFactory),
                "clam" => new ClamPizza(_ingredientFactory),
                "veggie" => new VeggiePizza(_ingredientFactory),
                _ => null
            };
            
            return pizza;
        }
    }
}