using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FW_GENERICS.Entity
{
    class Categories
    {
        [Identity]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
        public string Description { get; set; }


    }
}
