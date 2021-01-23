using System;

namespace CostumerMenager
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Apple";
            product1.ProductId = 1111;
            product1.ProductPrice = 2;
            product1.StockAmount = 50;

            Product product2 = new Product();
            product2.ProductName = "Orange";
            product2.ProductId = 2222;
            product2.ProductPrice = 5;
            product2.StockAmount = 40;

            Product product3 = new Product();
            product3.ProductName = "Tomato";
            product3.ProductId = 3333;
            product3.ProductPrice = 1;
            product3.StockAmount = 100;

            Product product4 = new Product();
            product4.ProductName = "Patato";
            product4.ProductId = 4444;
            product4.ProductPrice = 2.5;
            product4.StockAmount = 250;


            CartMenager cart = new CartMenager();

            string goon;
            do
            {
                Console.Write("What do you want to buy?  ");
                string product = Console.ReadLine();


                Product[] products = new Product[] { product1, product2, product3, product4 };

                foreach (Product prdct in products)
                {
                    if (product == prdct.ProductName)
                    {
                        Console.Write("How much?  ");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        cart.add(prdct, amount);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Nonexistent Product!");
                        break;
                    }
                }

                Console.WriteLine("Anything else? (Y/N)");
                goon = Console.ReadLine();
                Console.WriteLine("*************************************\n");
                if (goon == "N") break;
            } while (goon == "Y");

            Console.ReadKey();
        }
    }
}
