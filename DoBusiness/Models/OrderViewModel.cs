using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessEntitis;

namespace DoBusiness.Models
{
    public class DocumentViewModel
    {
        public Order PurchaseOrder { get; set; }
        public Person Customer { get; set; }
        public Product Products { get; set; }
        private IDocManager<Document> docmanager;

        public DocumentViewModel(IDocManager<Document> dm)
        {
            this.docmanager = dm;
        }

        public Document GetOrder()
        {
            return docmanager.GetDocument();
        }
    }
}