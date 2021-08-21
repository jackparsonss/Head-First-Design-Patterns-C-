using Head_First_Design_Patterns.Chapter_4___Factory_Pattern.Pizzas;

namespace Head_First_Design_Patterns.Chapter_4___Factory_Pattern.Stores
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = CreatePizza(type);
            
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            
            return pizza;
        }

        public abstract Pizza CreatePizza(string type);
    }
}