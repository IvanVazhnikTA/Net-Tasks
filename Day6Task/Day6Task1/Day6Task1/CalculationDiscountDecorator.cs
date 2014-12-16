using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Task1
{
   public class CalculationDiscountDecorator : CartDecorationBase
    {

       public int discount { get; set; }

       public CalculationDiscountDecorator(ICalculation component) : base(component) { }
      

        private ValueCalculator valueCalc = new ValueCalculator();

        public override void CalculateProduct()
        {
            this.component.CalculateProduct();
            this.DiscountPriceCalc(base.Products,discount);
        }

        public void DiscountPriceCalc(IEnumerable<Product> products,int discount)
        {
            Console.WriteLine("Discount price = {0}$", valueCalc.DiscountValueProducts(products, discount));

        }
               


    }

}
