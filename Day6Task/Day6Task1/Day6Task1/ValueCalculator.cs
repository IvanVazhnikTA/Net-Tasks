using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Task1
{
    class ValueCalculator
    {

        public decimal ValueProducts(IEnumerable<Product> products)
        {
            decimal sumOfProduct = 0;
            foreach (var product in products)
            {
                sumOfProduct += product.Price;
            }
            return sumOfProduct;
        }

        public decimal HalfValueProducts(IEnumerable<Product> products)
        {
            decimal sumOfProduct = ValueProducts(products) / 2;
           
            return sumOfProduct;

        }

        public decimal DiscountValueProducts(IEnumerable<Product> products, int discount)
        {

            decimal sumOfProduct = ValueProducts(products) - ((ValueProducts(products)*discount)/100);

            return sumOfProduct;



        }

    }
}
