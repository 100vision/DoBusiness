using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntitis
{
    public class Document
    {
        public int DocID { get; set; }
        public string  DocType { get; set; }

        public DateTime DocDate { get; set; }
        public Person Operator  { get; set; }
        public bool IsActive { get; set; }
        public string DocStatus { get; set; }
        public string ReferenceID { get; set; }

    }
}
