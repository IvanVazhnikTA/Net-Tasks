using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Task1
{
   public  class CartDecorationBase: ICalculation
    {

        protected readonly ICalculation component;

        public CartDecorationBase(ICalculation component)
    {
        this.component = component;
    }


        public virtual IEnumerable<Product> Products
    {
        get { return this.component.Products; }
        set { this.component.Products = value; }
    }
 
    public virtual void CalculateProduct()
    {
        this.component.CalculateProduct();
    }



    }
}
