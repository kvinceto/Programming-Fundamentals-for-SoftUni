using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace _07._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('/');
            List<Truck> trucks = new List<Truck>();
            List<Car> cars = new List<Car>();

            while (input[0] != "end")
            {
                if (input[0] == "Car")
                {
                    Car car = new Car(input[1], input[2], double.Parse(input[3]));
                    cars.Add(car);
                }
                else if (input[0] == "Truck")
                {
                    Truck truck = new Truck(input[1], input[2], double.Parse(input[3]));
                    trucks.Add(truck);
                }

                input = Console.ReadLine().Split('/');
            }

            cars = cars.OrderBy(car => car.Brand).ToList();
            trucks = trucks.OrderBy(truck => truck.Brand).ToList();

            if (cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                cars.ForEach(car => Console.WriteLine(car));
            }

            if (trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                trucks.ForEach(truck => Console.WriteLine(truck));
            }
        }
    }

    class Truck
    {
        public Truck(string brand, string model, double weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Weight { get; set; }
        public override string ToString()
        {
            return $"{Brand}: {Model} - {Weight}kg".ToString();
        }
    }

    class Car
    {
        public Car(string brand, string model, double hp)
        {
            Brand = brand;
            Model = model;
            HorsePower = hp;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double HorsePower { get; set; }
        public override string ToString()
        {
            return $"{Brand}: {Model} - {HorsePower}hp".ToString();
        }
    }

    class CatalogVehicle
    {
        public CatalogVehicle()
        {
            Car = new List<Car>();
            Truck = new List<Truck>();
        }
        public List<Car> Car { get; set; }
        public List<Truck> Truck { get; set; }
    }
}
