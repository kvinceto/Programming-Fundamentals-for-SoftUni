using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfArticles = int.Parse(Console.ReadLine());
            List<Article> listOfArticles = new List<Article>();
            for (int i = 0; i < numberOfArticles; i++)
            {
                string[] inputArticleInfo = Console.ReadLine().Split(", ").ToArray();
                Article article = new Article(inputArticleInfo[0], inputArticleInfo[1], inputArticleInfo[2]);
                listOfArticles.Add(article);

            }
            string inputLine = Console.ReadLine();
            listOfArticles.ForEach(article => Console.WriteLine(article));
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

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}".ToString();
        }
    }
}
