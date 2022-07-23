using System;
using System.Text.RegularExpressions;

namespace _4_02._Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfBarcode = int.Parse(Console.ReadLine());
            string barcodePattern = @"\A\@#+[A-Z]([A-Za-z\d]{5,})[A-Z]\@#+\Z";

            for (int i = 1; i <= numberOfBarcode; i++)
            {
                string input = Console.ReadLine();
                Regex regex = new Regex(barcodePattern);
                Match match = regex.Match(input);

                if (!match.Success)
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }

                string barcode = match.Groups[1].Value;
                string productGroup = String.Empty;
                bool noDigits = true;
                foreach (char symbol in barcode)
                {
                    if (Char.IsDigit(symbol))
                    {
                        productGroup += symbol;
                        noDigits = false;
                    }
                }

                if (noDigits)
                {
                    Console.WriteLine("Product group: 00");
                }
                else
                {
                    Console.WriteLine($"Product group: {productGroup}");
                }
            }
        }
    }
}
