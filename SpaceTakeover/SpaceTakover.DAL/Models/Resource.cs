using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTakeover.DAL.Models
{
    public class Resource
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public int Strength { get; set; }
        public int QuantityPerHour { get; set; }
        public int QuantityMined { get; set; }
        public int QuantityInInventory { get; set; }

        public Resource()
        {
            Name = "Test";
            Value = 1.0m;
            Strength = 100;
            QuantityPerHour = 0;
            QuantityMined = 0;
            QuantityInInventory = 0;
        }
        public Resource(string name, decimal value, int strength, int quantityPerHour, int quantityMined)
        {
            Name = name;
            Value = value;
            Strength = strength;
            QuantityPerHour = quantityPerHour;
            QuantityMined = quantityMined;
            QuantityInInventory = 0;
        }
    }
}
