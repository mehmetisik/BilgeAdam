using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADONET_STORED_PROC.Entity
{
   public class Product
    {

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public int CategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public int UnitsOnOrder { get; set; }
        public bool Discontinued { get; set; }


    }
}
