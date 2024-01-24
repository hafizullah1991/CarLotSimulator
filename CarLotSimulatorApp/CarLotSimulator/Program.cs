using Microsoft.VisualBasic;
using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            // dot notation
            Car firstCar = new Car();
           firstCar.Make = "Bugatti Chiron";
           firstCar.Year = 2024;
           firstCar.EngineNoise = "Vroom Vroom";
           firstCar.HonkNoise = "Loud Revving Horn";
            firstCar.IsDriveable= true;

            Console.WriteLine("======== initializer way==========");
            Car firstCar2 = new Car() { Make = "Bugatti", Year = 2024, EngineNoise = "Vroom", HonkNoise = "Loud" , IsDriveable = true};
            Console.WriteLine($"{firstCar2.Make} {firstCar2.Year} {firstCar2.EngineNoise} {firstCar2.HonkNoise} {firstCar2.IsDriveable}");

            Console.WriteLine("*************Custom Constructive****************");


            Car customCar = new Car("Toyota", 2024, "Vroom Vroom", "loud", true);
            Console.WriteLine($"{customCar.Make} {customCar.Year} {customCar.EngineNoise} {customCar.HonkNoise} {customCar.IsDriveable}");



            Console.WriteLine("____________Example 2-----------------");
            Car secondCar = new Car();
            secondCar.Make = "Lamborghini ";
            secondCar.Year = 2023;
            secondCar.EngineNoise = "Thunderous V12";
            secondCar.HonkNoise = "Horn Blast";
            secondCar.IsDriveable= true;


            Console.WriteLine("=========initializing =============");
            Car secondCar2 = new Car() { Make = "lamborghini", Year = 2020, EngineNoise = "Thunderous", HonkNoise = "Honrn", IsDriveable = true };

            Console.WriteLine($"{secondCar2.Make}");
            Console.WriteLine("==========Custom Constructive++++++++++++");

            Car secondCustom = new Car("Lamberghini", 2022, "Thundrous", "Horn blast", true);
            Console.WriteLine($"this is Custom Constructive {secondCustom.Make} {secondCustom.Year} {secondCustom.EngineNoise} {secondCustom.HonkNoise} {secondCustom.IsDriveable}");


            //Call each of the methods for each car
            Console.WriteLine("result");
            firstCar.MakeEngineNoise();
           
            secondCar.MakeHonkNoise();

       

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//
            CarLot Carlist = new CarLot();

            Carlist.listOfCars.Add(firstCar);
            Carlist.listOfCars.Add(secondCar2);
            Carlist.listOfCars.Add(secondCar);
            foreach(Car item in Carlist.listOfCars)
            {
                Console.WriteLine($"{item.Make}");
                Console.WriteLine($"{item.Year}");
            }
            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
