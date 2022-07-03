using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputArticleInfo = Console.ReadLine().Split(", ").ToArray();
            Article article = new Article(inputArticleInfo[0], inputArticleInfo[1], inputArticleInfo[2]);

            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commandLine = Console.ReadLine().Split(": ").ToArray();
                if (commandLine[0] == "Edit")
                {
                    article.Edit(commandLine[1]);
                }
                else if (commandLine[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(commandLine[1]);
                }
                else if(commandLine[0] == "Rename")
                {
                    article.Rename(commandLine[1]);
                }
            }

            Console.WriteLine(article);
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string content) => Content = content;
        public void ChangeAuthor(string author) => Author = author;
        public void Rename(string title) => Title = title;
        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}".ToString();
        }
    }
}
