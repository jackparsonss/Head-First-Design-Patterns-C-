namespace Head_First_Design_Patterns.Chapter_3___Decorator_Pattern
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage Beverage;

        public abstract string GetDescription();

        public new Size GetSize()
        {
            return Beverage.GetSize();
        }
    }

    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Mocha";
        }

        public override double Cost()
        {
            if (Beverage.GetSize() == Size.TALL)
            {
                return Beverage.Cost() + .15;
            }
            if (Beverage.GetSize() == Size.VENTI)
            {
                return Beverage.Cost() + .20;
            }

            return Beverage.Cost() + .25;
        }
    }
    
    public class SteamedMilk : CondimentDecorator
    {
        public SteamedMilk(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Steamed Milk";
        }

        public override double Cost()
        {
            if (Beverage.GetSize() == Size.TALL)
            {
                return Beverage.Cost() + .05;
            }
            if (Beverage.GetSize() == Size.VENTI)
            {
                return Beverage.Cost() + .10;
            }

            return Beverage.Cost() + .15;
        }
    }
    
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Soy";
        }

        public override double Cost()
        {
            if (Beverage.GetSize() == Size.TALL)
            {
                return Beverage.Cost() + .10;
            }
            if (Beverage.GetSize() == Size.VENTI)
            {
                return Beverage.Cost() + .15;
            }

            return Beverage.Cost() + .20;
        }
    }
    
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Whip";
        }

        public override double Cost()
        {
            if (Beverage.GetSize() == Size.TALL)
            {
                return Beverage.Cost() + .05;
            }
            if (Beverage.GetSize() == Size.VENTI)
            {
                return Beverage.Cost() + .15;
            }

            return Beverage.Cost() + .20;
        }
    }
}