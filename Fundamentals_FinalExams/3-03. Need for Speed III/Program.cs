using System;
using System.Collections.Generic;

namespace _3_03._Need_for_Speed_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            Dictionary<string, Car> ownedCars = new Dictionary<string, Car>();

            for (int i = 1; i <= numberOfCars; i++)
            {
                string[] cars = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                string model = cars[0];
                int mileage = int.Parse(cars[1]);
                double fuel = double.Parse(cars[2]);
                ownedCars.Add(model, new Car(model, mileage, fuel));
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "Stop")
                {
                    break;
                }

                switch (command[0])
                {
                    case "Drive":
                        DriveCommand(command, ownedCars);   break;
                    case "Refuel":
                        RefuelCommand(command, ownedCars); break;
                    case "Revert":
                        RevertCommand(command, ownedCars); break;
                }
            }

            foreach (var car in ownedCars)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value.Mileage} kms, Fuel in the tank: {car.Value.Fuel} lt.");   
            }
        }

        private static void RevertCommand(string[] command, Dictionary<string, Car> ownedCars)
        {
            string car = command[1];
            int km = int.Parse(command[2]);

            ownedCars[car].Mileage -= km;
            if (ownedCars[car].Mileage < 10000)
            {
                ownedCars[car].Mileage = 10000;
            }
            else
            {
                Console.WriteLine($"{car} mileage decreased by {km} kilometers");
            }
        }

        private static void RefuelCommand(string[] command, Dictionary<string, Car> ownedCars)
        {
            string car = command[1];
            double fuel = double.Parse(command[2]);
            double refueled = 0;
            if (ownedCars[car].Fuel + fuel > 75)
            {
                refueled = 75 - ownedCars[car].Fuel;
                ownedCars[car].Fuel = 75;
            }
            else
            {
                ownedCars[car].Fuel += fuel;
                refueled = fuel;
            }

            Console.WriteLine($"{car} refueled with {refueled} liters");
        }

        private static void DriveCommand(string[] command, Dictionary<string, Car> ownedCars)
        {
           string car = command[1];
           int distance = int.Parse(command[2]);
           double fuel = double.Parse(command[3]);
           if (ownedCars[car].Fuel >= fuel)
           {
               ownedCars[car].Fuel -= fuel;
               ownedCars[car].Mileage += distance;
               Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
               if (ownedCars[car].Mileage >= 100000) 
               {
                   Console.WriteLine($"Time to sell the {car}!");
                   ownedCars.Remove(car);
               }
           }
           else
           {
               Console.WriteLine("Not enough fuel to make that ride");
           }
        }
    }

    class Car
    {
        public Car(string model, int mileage, double fuel)
        {
            Model = model;
            Mileage = mileage;
            Fuel = fuel;
        }
        public string Model { get; set; }
        public int Mileage { get; set; }
        public double Fuel { get; set; }
    }
}
