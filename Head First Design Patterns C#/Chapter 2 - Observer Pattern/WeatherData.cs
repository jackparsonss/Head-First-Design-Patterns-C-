using System;
using System.Collections.Generic;

namespace Head_First_Design_Patterns.Chapter_2___Observer_Pattern
{
    public class WeatherData : ISubject
    {
        private List<IObserver> _observers;
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }
        
        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update();
            }
        }
        
        private void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            MeasurementsChanged();
        }
    }
}