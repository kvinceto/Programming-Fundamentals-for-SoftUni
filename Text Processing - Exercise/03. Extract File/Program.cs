using System;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();

            int indexOfStart = path.LastIndexOf('\\') + 1;
            int lengthOfFileName = path.LastIndexOf('.') - indexOfStart;

            string fileName = path.Substring(indexOfStart, lengthOfFileName);
            int fileExtenstionLength = path.Length - path.LastIndexOf('.');
            string fileExtenstion = path.Substring(path.LastIndexOf('.') + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtenstion}");
        }
    }
}
