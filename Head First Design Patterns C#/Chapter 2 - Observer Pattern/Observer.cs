namespace Head_First_Design_Patterns.Chapter_2___Observer_Pattern
{
    public interface IObserver
    {
        public void Update();
    }

    public interface ISubject
    {
        public void RegisterObserver(IObserver o);
        public void RemoveObserver(IObserver o);
        public void NotifyObservers();
    }
}