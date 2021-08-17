using System;
using Head_First_Design_Patterns.Chapter_1___Intro;
using Head_First_Design_Patterns.Chapter_2___Observer_Pattern;

namespace Head_First_Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chapter1();
            Chapter2();
        }

        private static void Chapter1()
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            Duck model = new ModelDuck();
            model.PerformFly();
            model.SetFlyBehaviour(new FlyRocketPowered());
            model.PerformFly();
        }

        private static void Chapter2()
        {
            var weatherData = new WeatherData();
            var currentDisplay = new CurrentConditionsDisplay(weatherData);
            
            weatherData.SetMeasurements(24, 65, 30.4f);
            weatherData.SetMeasurements(21, 75, 31.4f);
            weatherData.SetMeasurements(27, 55, 29.4f);
        }
    }
}