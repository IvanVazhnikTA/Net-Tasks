using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Task1
{
    public interface ICalculation
    {
           IEnumerable<Product> Products { get; set; }
          void CalculateProduct();
    }
}
