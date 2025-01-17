﻿using System;
using Head_First_Design_Patterns.Chapter_1___Intro;
using Head_First_Design_Patterns.Chapter_2___Observer_Pattern;
using Head_First_Design_Patterns.Chapter_3___Decorator_Pattern;
using Head_First_Design_Patterns.Chapter_4___Factory_Pattern.Pizzas;
using Head_First_Design_Patterns.Chapter_4___Factory_Pattern.Stores;
using Head_First_Design_Patterns.Chapter_5___Singleton_Pattern;
using Head_First_Design_Patterns.Chapter_6___Command_Pattern;
using Head_First_Design_Patterns.Chapter_6___Command_Pattern.Devices;

namespace Head_First_Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chapter1();
            // Chapter2();
            // Chapter3();
            // Chapter4();
            // Chapter5();
            Chapter6();
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

        private static void Chapter3()
        {
            // Espresso
            Beverage beverage = new Expresso();
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost());

            // Double Mocha Dark Roast With Whip
            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.GetDescription() + " $" + beverage2.Cost());

            // Soy House Blend With Mocha and Whip
            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.GetDescription() + " $" + beverage3.Cost());

        }

        private static void Chapter4()
        {
            PizzaStore nyStore = new NYStylePizzaStore();
            PizzaStore chicagoStore = new ChicagoStylePizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine($"Jim ordered a {pizza.GetName()} \n");

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine($"Bob ordered a {pizza.GetName()} \n");
        }

        private static void Chapter5()
        {
            ChocolateBoiler chocolateBoiler = ChocolateBoiler.GetInstance();
            chocolateBoiler.Fill();
            chocolateBoiler.Boil();
            chocolateBoiler.Drain();
            
            // Returns the same instance
            ChocolateBoiler chocolateBoiler2 = ChocolateBoiler.GetInstance();
        }
        
        private static void Chapter6()
        {
            var remote = new SimpleRemoteControl();
            var light = new Light();
            var lightOn = new LightOnCommand(light);
            var garageDoor = new GarageDoor();
            var garageDoorOpen = new GarageDoorOpenCommand(garageDoor);
            
            remote.SetCommand(lightOn);
            remote.ButtonWasPressed();
            remote.SetCommand(garageDoorOpen);
            remote.ButtonWasPressed();
            
        }
    }
}
    