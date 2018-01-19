using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntitis
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string  Unit { get; set; }
        public DateTime CreationTime { get; set; }  
        public string  ProductType { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
