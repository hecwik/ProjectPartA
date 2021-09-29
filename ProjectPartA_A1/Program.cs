using System;

namespace ProjectPartA_A1
{
    class Program
    {
        struct Article
        {
            public string Name;
            public decimal Price;
        }

        const int _maxNrArticles = 10;
        const int _maxArticleNameLength = 20;
        const decimal _vat = 0.25M;

        static Article[] articles = new Article[_maxNrArticles];
        static int nrArticles;

        static void Main(string[] args)
        {
            ShoppingMenu();
            ReadArticles();
            PrintReciept();
        }

        private static void ReadArticles()
        {
            bool amountArticlesEntered = false;
            while (amountArticlesEntered == false)
            {
                Console.Write("How many articles would you like to buy (between 1-10)?: ");

                // tryparse on console.readline input
                if (int.TryParse(Console.ReadLine(), out int amountOfArticles))
                {
                    if (amountOfArticles > 0 && amountOfArticles <= 10)
                    {
                        Console.WriteLine($"You want to purchase {amountOfArticles}.\n");
                        // set boolean variable to true since a valid number of articles has been entered
                        amountArticlesEntered = true;
                    }

                    else if (amountOfArticles < 1)
                    {
                        Console.WriteLine($"No articles entered, please enter an article.\n");
                        amountArticlesEntered = false;
                    }

                    else if (amountOfArticles > 10)
                    {
                        Console.WriteLine($"{amountOfArticles} is too many articles. Maximum number of articles is 10.\n");
                        amountArticlesEntered = false;
                    }
                }

                // if tryparse fails, display message
                else
                {
                    Console.WriteLine("Wrong input - please enter a number between 1-10.");
                    amountArticlesEntered = false;
                }
            }




        }
        private static void PrintReceipt()
        {



            //Your code to print out a receipt

        }

        public static void ShoppingMenu()
        {
            Console.WriteLine("== Welcome to Project Part A! ==");
            Console.WriteLine("Let us print a receipt!\n");
        }
        public static int CountArticles()
        {
            foreach (var item in articles)
            {
                if(item.Name != null)
                nrArticles++;
            }
            return nrArticles;
        }

        public static string AddArticle(Article[] articles, Article article)
        {
            for (int i = 0; i < articles.Length; i++)
            {

            }
        }
    }
}
