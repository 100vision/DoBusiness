using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntitis
{
    public class Order : Document
    {
        public decimal GrandTotal { get; set; }
        public List<Product> Products { get; set; }
        public DateTime LeadTime { get; set; }
        public DateTime EstimateDeliveryTime { get; set; }
        public Person Partner { get; set; }
    }
}
