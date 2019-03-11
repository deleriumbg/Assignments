using System;
using System.Collections.Generic;
using System.Linq;
using Assignment2.Contracts;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = AddCars();
            PrintCars(cars);
        }

        private static void PrintCars(List<ICar> cars)
        {
            // Command can be only "fragile" or "flamable"
            string command = Console.ReadLine();
            switch (command)
            {
                case "fragile":
                    cars = cars.Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(t => t.Pressure < 1)).ToList();
                    break;
                case "flamable":
                    cars = cars.Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250).ToList();
                    break;
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}");
            }
        }

        private static List<ICar> AddCars()
        {
            var cars = new List<ICar>();
            var numberOfCars = int.Parse(Console.ReadLine());

            while (cars.Count < numberOfCars)
            {
                var input = Console.ReadLine()?.Split();

                /*
                 * Information about a car in the format:
                 * “<Model> <EngineSpeed> <EnginePower> <CargoWeight> <CargoType> <Tire1Pressure> <Tire1Age> <Tire2Pressure> <Tire2Age> <Tire3Pressure> <Tire3Age> <Tire4Pressure> <Tire4Age>” 
                 */
                var engine = new Engine(int.Parse(input[1]), int.Parse(input[2]));
                var cargo = new Cargo(int.Parse(input[3]), input[4]);
                var tires = new Tire[]
                {
                    new Tire(double.Parse(input[5]), int.Parse(input[6])),
                    new Tire(double.Parse(input[7]), int.Parse(input[8])),
                    new Tire(double.Parse(input[9]), int.Parse(input[10])),
                    new Tire(double.Parse(input[11]), int.Parse(input[12])),
                };

                cars.Add(new Car(input[0], engine, cargo, tires));
            }

            return cars;
        }
    }
}
