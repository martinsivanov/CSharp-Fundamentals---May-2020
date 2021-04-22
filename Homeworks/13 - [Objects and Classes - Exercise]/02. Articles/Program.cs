using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> list = new List<Article>();
            string[] articlesCommand = Console.ReadLine().Split(", ").ToArray();
            Article article = new Article(articlesCommand[0], articlesCommand[1], articlesCommand[2]);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                string[] commands = Console.ReadLine().Split(": ").ToArray();

                if (commands[0] == "Edit")
                {
                    article.Content = commands[1];
                }
                else if (commands[0] == "ChangeAuthor")
                {
                    article.Author = commands[1];
                }
                else if (commands[0] == "Rename")
                {
                    article.Title = commands[1];
                }


            }
            list.Add(article);
            Console.WriteLine(String.Join(" ", list));


        }

        public class Article
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public Article(string title, string content, string author)
            {
                this.Title = title;
                this.Content = content;
                this.Author = author;
            }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }

        }
    }
    
}
