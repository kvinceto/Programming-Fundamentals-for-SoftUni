using System;

namespace _05._HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string content = Console.ReadLine();

            Console.WriteLine("<h1>");
            Console.WriteLine(title);
            Console.WriteLine("</h1>");
            Console.WriteLine("<article>");
            Console.WriteLine(content);
            Console.WriteLine("</article>");

            while (true)
            {
                string comment = Console.ReadLine();
                if (comment == "end of comments")
                {
                    break;
                }

                Console.WriteLine("<div>");
                Console.WriteLine(comment);
                Console.WriteLine("</div>");
            }
        }
    }
}
