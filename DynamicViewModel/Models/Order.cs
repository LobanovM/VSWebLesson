using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicViewModel.Models
{
    public class Order
    {
        public String Name { get; set; }
        public Dictionary<String, Item> Items { get; set; }
    }
}