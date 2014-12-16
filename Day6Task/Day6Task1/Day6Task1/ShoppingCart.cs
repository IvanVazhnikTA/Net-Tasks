using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Task1
{
    public class ShoppingCart : ICalculation
    {
        private ValueCalculator valueCalc;

        public IEnumerable<Product> Products { get; set; }

        public ShoppingCart()
        {
            valueCalc = new ValueCalculator();
        }

        public void CalculateProduct()
        {
           Console.WriteLine("Total price = {0}$",valueCalc.ValueProducts(Products));
        }


    }
}
