using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingListAPI2.Models
{
    public class Grocery
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool Purchased { get; set; }
    }
}
