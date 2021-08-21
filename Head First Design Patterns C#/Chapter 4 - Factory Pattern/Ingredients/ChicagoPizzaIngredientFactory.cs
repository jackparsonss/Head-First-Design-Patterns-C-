namespace Head_First_Design_Patterns.Chapter_4___Factory_Pattern.Ingredients
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public Cheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public Veggies[] CreateVeggies()
        {
            Veggies[] veggies = { new Spinach(), new EggPlant(), new BlackOlives() };
            return veggies;
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Clams CreateClam()
        {
            return new FrozenClams();
        }
    }
}