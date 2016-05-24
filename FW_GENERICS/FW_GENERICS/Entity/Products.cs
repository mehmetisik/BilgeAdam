using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FW_GENERICS.Entity
{
    class Products
    {
        [Identity]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }


    }
}
