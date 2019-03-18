using System;
using System.Collections.Generic;

namespace StockPurchaseDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("NTDOY", "Nintendo");
            stocks.Add("MSFT", "Microsoft");
            stocks.Add("FNKO", "Funko");
            stocks.Add("BBY", "Best Buy");
            
            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

            purchases.Add((ticker: "GE", shares: 150, price: 23.21));
            purchases.Add((ticker: "CAT", shares: 32, price: 17.87));
            purchases.Add((ticker: "MSFT", shares: 80, price: 19.02));
            purchases.Add((ticker: "FNKO", shares: 120, price: 21.66));
            purchases.Add((ticker: "BBY", shares: 60, price: 69.63));
            purchases.Add((ticker: "NTDOY", shares: 100, price: 34.92));

            Dictionary<string, double> ownershipReport = new Dictionary<string, double>();

            foreach(var company in stocks)
            {
                //Console.WriteLine(company.Value);
                foreach(var something in purchases)
                {
                    var price = something.price;
                    var shares = something.shares;
                    var valuation = price * shares;


                    Console.WriteLine($"{company}: {valuation}");
                    
                }
            }
            //Console.WriteLine(ownershipReport);
            //foreach (var valuation in ownershipReport)
            //{
            //    Console.WriteLine($"Valuation: {valuation}");
            //}

            Console.ReadLine();

            // Add more for each stock you added to the stocks dictionary
        }
    }
}
