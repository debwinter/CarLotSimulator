using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carLot = new List<Car>();

            //TODO

            //Create a separate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars

            //*************BONUS*************//
            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            Car car1 = new Car();
            car1.Year = 2006;
            car1.Make = "Dodge";
            car1.Model = "Sprinter 2500";
            car1.EngineNoise = "chugga";
            car1.HonkNoise = "HONK";
            car1.isDriveable = true;

            carLot.Add(car1);

            Car car2 = new Car()
            {
                Year = 2007,
                Make = "Ford",
                Model = "Transit",
                EngineNoise = "whine",
                HonkNoise = "waaaah",
                isDriveable = false
            };

            carLot.Add(car2);

            Car car3 = new Car(2012, "Dodge", "Ram");
            car3.isDriveable = true;

            carLot.Add(car3);

            Car car4 = new Car(2023, "Mercedes", "Sprinter", "zoom", "boop", true);

            carLot.Add(car4);

            //Call each of the methods for each car

            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);
            Console.WriteLine();
            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);
            Console.WriteLine();
            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);
            Console.WriteLine();
            car4.MakeEngineNoise(car4.EngineNoise);
            car4.MakeHonkNoise(car4.HonkNoise);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            int i = 1;
            foreach (Car car in carLot)
            {
                Console.WriteLine($"PARKING SPACE #{i}:");
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
                Console.WriteLine();
                i++;
            }
        }
    }
}
