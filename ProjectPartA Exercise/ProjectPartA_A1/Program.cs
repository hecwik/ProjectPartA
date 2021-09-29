using System;

namespace ProjectPartA_A1
{
    class Program
    {
        public struct Article
        {
            public string Name;
            public decimal Price;

            public string ToString()
            {
                return $"{Name}; {Price}";
            }
        }

        const int _maxNrArticles = 10;
        const int _maxArticleNameLength = 20;
        const decimal _vat = 0.25M;

        static Article[] articles = new Article[_maxNrArticles];
        static int nrArticles;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Project part A!" +
                "\nLet's print a receipt!\n");

            ReadArticles();
            PrintReceipt();
        }

        private static void ReadArticles()
        {
            Console.WriteLine("Please enter the name of the article and price: ");
            Console.WriteLine("(for example: Beer, 2,25)");

            Article article1 = new Article
            {
                Name = Console.ReadLine(),
                Price = Convert.ToDecimal(Console.ReadLine())
            };
            Console.WriteLine($"Here is your article: {article1.ToString()}");

            
        }
        private static void PrintReceipt()
        {
            //Your code to print out a reciept

        }
    }
}
