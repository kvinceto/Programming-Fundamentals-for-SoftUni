using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> listOfCompanies = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                if (input[0] == "End")
                {
                    break;
                }

                string company = input[0];
                string iD = input[1];

                if (listOfCompanies.ContainsKey(company))
                {
                    bool isInTheList = false;
                    foreach (var id in listOfCompanies.Values)
                    {
                        foreach (var c in id)
                        {
                            if (c == iD)
                            {
                                isInTheList = true;
                                break;
                            }
                        }

                        if (isInTheList)
                        {
                            break;
                        }
                    }

                    if (isInTheList)
                    {
                        continue;
                    }
                    else
                    {
                        listOfCompanies[company].Add(iD);
                    }
                }
                else
                {
                    listOfCompanies.Add(company, new List<string>(){iD});
                }
            }

            foreach (var company in listOfCompanies)
            {
                Console.WriteLine($"{company.Key}");
                foreach (var c in company.Value)
                {
                    Console.WriteLine($"-- {c}");
                }
            }
        }
    }
}
