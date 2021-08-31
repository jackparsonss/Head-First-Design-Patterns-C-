namespace Head_First_Design_Patterns.Chapter_5___Singleton_Pattern
{
    public class ChocolateBoiler
    {
        public bool Empty { get; set; }
        public bool Boiled { get; set; }
        private static ChocolateBoiler _uniqueInstance;

        private ChocolateBoiler()
        {
            Empty = true;
            Boiled = false;
        }

        public static ChocolateBoiler GetInstance()
        {
            lock(_uniqueInstance)
            {
                if (_uniqueInstance == null)
                {
                    return new ChocolateBoiler();
                }

                return _uniqueInstance;    
            }
        }

        public void Fill()
        {
            if (Empty)
            {
                Empty = false;
                Boiled = false;
            }
        }

        public void Drain()
        {
            if (!Empty && Boiled)
            {
                Empty = true;
            }
        }

        public void Boil()
        {
            if (!Empty && !Boiled)
            {
                Boiled = true;
            }
        }
    }
}