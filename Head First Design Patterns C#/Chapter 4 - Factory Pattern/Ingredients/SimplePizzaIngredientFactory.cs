namespace Head_First_Design_Patterns.Chapter_4___Factory_Pattern.Ingredients
{
    public class SimplePizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public Cheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public Veggies[] CreateVeggies()
        {
            Veggies[] veggies = { new Spinach(), new RedPepper(), new BlackOlives() };
            return veggies;
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Clams CreateClam()
        {
            return new Clams();
        }
    }
}