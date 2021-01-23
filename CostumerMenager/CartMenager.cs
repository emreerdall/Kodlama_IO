using System;
using System.Collections.Generic;
using System.Text;

namespace CostumerMenager
{
    class CartMenager
    {
        public void add(Product product,int shopAmount)
        {
            Console.WriteLine($"{product.ProductName} added to cart");
            Console.WriteLine($"Product Amount: {shopAmount}");
            Console.WriteLine($"The Total Price: {shopAmount * product.ProductPrice}");
        }
    }
}
