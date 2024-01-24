using System;

namespace CarLotSimulator
{
    internal class Car
    {
        public string Make { get; set; }
        public int Year { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public Car()
        {
            // Default constructor
        }

        public Car(string make, int year, string engineNoise, string honkNoise, bool isDriveable = true)
        {
            Make = make;
            Year = year;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }

        public void MakeEngineNoise()
        {
            Console.WriteLine($"The {Make} is making the engine noise: {EngineNoise} and is {IsDriveable}");
        }

        public void MakeHonkNoise()
        {
            Console.WriteLine($"The {Make} is making the honk noise: {HonkNoise} and is {IsDriveable}");
        }
    }
}