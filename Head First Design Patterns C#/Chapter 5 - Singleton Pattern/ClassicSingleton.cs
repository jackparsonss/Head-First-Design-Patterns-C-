namespace Head_First_Design_Patterns.Chapter_5___Singleton_Pattern
{
    public class ClassicSingleton
    {
        private static ClassicSingleton _uniqueInstance;

        // Setting the constructor to private blocks out users from creating a new instance explicitly
        private ClassicSingleton() { }

        public static ClassicSingleton GetInstance()
        {
            if (_uniqueInstance == null)
            {
                return new ClassicSingleton();
            }

            return _uniqueInstance;
        }
    }

    public enum Singleton
    {
        UNIQUE_INSTANCE
    }
}