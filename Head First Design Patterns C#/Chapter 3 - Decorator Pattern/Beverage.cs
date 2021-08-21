namespace Head_First_Design_Patterns.Chapter_3___Decorator_Pattern
{
    public abstract class Beverage
    {
        public enum Size { TALL, GRANDE, VENTI }

        protected Size size = Size.TALL;
        protected string Description = "Unknown Beverage";

        public string GetDescription()
        {
            return Description;
        }

        public void SetSize(Size _size)
        {
            size = _size;
        }

        public virtual Size GetSize()
        {
            return size;
        }
        
        public abstract double Cost();
    }
}