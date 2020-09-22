using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTakeover.Data.Models
{
    public class Resource
    {
        public string name { get; set; }
        public decimal value { get; set; }
        public int strength { get; set; }
        public int quantity { get; set; }

        public Resource()
        {
            this.name = "Test";
            this.value = 1.0m;
            this.strength = 100;
            this.quantity = 0;
        }
        public Resource(string name, decimal value, int strength, int quantity)
        {
            this.name = name;
            this.value = value;
            this.strength = strength;
            this.quantity = quantity;
        }
    }
}
