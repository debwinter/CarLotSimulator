using System;
namespace CarLotSimulator
{
    //Create a separate class file called Car
    //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
    //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
    //The methods should take one string parameter: the respective noise property

    public class Car
	{
		public Car()
		{
		}

        public Car(int year, string make, string model)
        {
            Year = year;
            Make = make;
            Model = model;
        }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool canDrive)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            isDriveable = canDrive;
        }

        public int? Year { get; set; } = null;

        public string Make { get; set; } = "unknown";

        public string Model { get; set; } = "unknown";

        public string EngineNoise { get; set; } = "vroom";

        public string HonkNoise { get; set; } = "beep";

        public bool isDriveable { get; set; } = false;

        public void MakeEngineNoise(string noise)
        {
            EngineNoise = noise;
            Console.WriteLine($"Car says: {noise} {noise}!");
        }

        public void MakeHonkNoise(string noise)
        {
            HonkNoise = noise;
            Console.WriteLine($"Horn says: {noise} {noise}!");
        }

        public void PrintCar(Car car)
        {
            Console.WriteLine($"{Year} {Make} {Model}");
        }
	}
}

