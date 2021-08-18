namespace Head_First_Design_Patterns.Chapter_3___Decorator_Pattern
{
    public class Expresso : Beverage
    {
        public Expresso()
        {
            Description = "Espresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }

    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House Blend Coffee";
        }

        public override double Cost()
        {
            return .89;
        }
    }
    
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Dark Roast Coffee";
        }

        public override double Cost()
        {
            return .99;
        }
    }
    
    public class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Decaffinated Coffee";
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
    
    
}