using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day6Task1;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var cart = new ShoppingCart()
                {
                    Products = new List<Product>()
                {
                    new Product {Name = "Product 1", Category = "C1", Description = "no", ProductID = 1, Price = 100},
                    new Product {Name = "Product 2", Category = "C2", Description = "no", ProductID = 2, Price = 200}
                    
                   
                }
                };

                Calculate(cart);

                var cartHalf = new CalculationHalfPriceDecorator(cart);
              

                Calculate(cartHalf);


                var cartDiscount = new CalculationDiscountDecorator(cart);
                cartDiscount.discount = 5;
                Calculate(cartDiscount);

            }

           
           

        }

        public static void Calculate(ICalculation element)
        {
            element.CalculateProduct();
            Console.ReadLine();
        }

    }
}
