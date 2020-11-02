using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace SpaceTakeover.DAL.Models
{
    public class Inventory
    {
        public int Size { get; set; }
        public int MaxSize { get; set; }
        public Dictionary<string, Resource> Resources { get; set; }

        public Inventory()
        {
            Size = 10;
            MaxSize = 100;
            Resources = new Dictionary<string, Resource>();
        }
        public Inventory(int size, int maxSize, Dictionary<string, Resource> resources)
        {
            this.Size = size;
            this.MaxSize = maxSize;
            this.Resources = resources;
        }
    }
}
