using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot lot1 = new CarLot();
            lot1.carLot = new List<Car>();

            //adding car1 using dot notation
            Car car1 = new Car();
            car1.Year = 2006;
            car1.Make = "Dodge";
            car1.Model = "Sprinter 2500";
            car1.EngineNoise = "chugga";
            car1.HonkNoise = "HONK";
            car1.isDriveable = true;

            //calling methods and parking it in the lot (as per static exercise)
            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);
            ParkCar(car1, lot1.carLot);
            Console.WriteLine();

            //adding car2 using object initializer syntax
            Car car2 = new Car()
            {
                Year = 2007,
                Make = "Ford",
                Model = "Transit",
                EngineNoise = "whine",
                HonkNoise = "waaaah",
                isDriveable = false
            };

            //calling methods and parking it in the lot (as per static exercise)
            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);
            ParkCar(car2, lot1.carLot);
            Console.WriteLine();

            //adding car3 using custom constructor #1
            Car car3 = new Car(2012, "Dodge", "Ram");
            car3.isDriveable = true;

            //calling methods and parking it in the lot (as per static exercise)
            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);
            ParkCar(car3, lot1.carLot);
            Console.WriteLine();

            //adding car4 using custom constructor #2
            Car car4 = new Car(2023, "Mercedes", "Sprinter", "zoom", "boop", true);

            //calling methods and parking it in the lot (as per static exercise)
            car4.MakeEngineNoise(car4.EngineNoise);
            car4.MakeHonkNoise(car4.HonkNoise);
            ParkCar(car4, lot1.carLot);
            Console.WriteLine();
            
            Console.WriteLine();

            //Bonus exercise from original assignment

            int i = 1;
            foreach (Car car in lot1.carLot)
            {
                Console.WriteLine($"PARKING SPACE #{i}:");
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
                Console.WriteLine();
                i++;
            }
        }

        //Method for static exercise
        static void ParkCar(Car car, List<Car> list)
        {
            list.Add(car);
            CarLot.numberOfCars++;
            if (CarLot.numberOfCars == 1)
            {
                Console.WriteLine($"There is now {CarLot.numberOfCars} car parked in the lot.");
            }
            else
            {
                Console.WriteLine($"There are now {CarLot.numberOfCars} cars parked in the lot.");
            }
        }
    }
}
