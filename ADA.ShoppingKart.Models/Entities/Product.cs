using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADA.ShoppingKart.Models.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public int Description { get; set; }
        public string  Categories { get; set; }
    }
}
