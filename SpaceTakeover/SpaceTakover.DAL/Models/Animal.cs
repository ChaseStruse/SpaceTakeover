using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTakover.DAL.Models
{
    public class Animal
    {
        public string Name { get; set; }
        public Dictionary<string, Item> ItemsDropped { get; set; }
        public int Strength { get; set; }
        public int Health { get; set; }
    }
}
