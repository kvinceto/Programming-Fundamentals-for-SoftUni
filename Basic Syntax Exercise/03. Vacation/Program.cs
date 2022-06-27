using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;

            switch (type)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            price = 8.45;
                            break;
                        case "Saturday":
                            price = 9.80;
                            break;
                        case "Sunday":
                            price = 10.46;
                            break;
                    }
                    break;
                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            price = 10.90;
                            break;
                        case "Saturday":
                            price = 15.60;
                            break;
                        case "Sunday":
                            price = 16;
                            break;
                    }
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            price = 15;
                            break;
                        case "Saturday":
                            price = 20;
                            break;
                        case "Sunday":
                            price = 22.50;
                            break;
                    }
                    break;
            }
            double sum = people * price;
            if (type == "Students" && people >= 30)
            {
                sum -= sum * 0.15;
            }
            else if (type == "Business" && people >= 100)
            {
                sum = price * (people - 10);
            }
            else if (type == "Regular" && (people >= 10 && people <= 20))
            {
                sum -= sum * 0.05;
            }
            Console.WriteLine($"Total price: {sum:f2}");
        }
    }
}
