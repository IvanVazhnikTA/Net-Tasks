using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Task1
{
  
     public class CalculationHalfPriceDecorator : CartDecorationBase
    {

        public CalculationHalfPriceDecorator(ICalculation component) : base(component) { }

        private ValueCalculator valueCalc = new ValueCalculator();
        public override void CalculateProduct()
        {
           this.component.CalculateProduct();
           this.HalfPriceCalc(base.Products);
           
        }

        public void HalfPriceCalc(IEnumerable<Product> products)
        {
            Console.WriteLine("Half price = {0}$", valueCalc.HalfValueProducts(products));

        }
               
    }
}
