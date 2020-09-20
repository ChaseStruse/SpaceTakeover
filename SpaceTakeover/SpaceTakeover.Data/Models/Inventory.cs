using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace SpaceTakeover.Data.Models
{
    public class Inventory
    {
        public int size { get; set; }
        public int maxSize { get; set; }
        public Dictionary<string, Resource> resources { get; set; }

        public Inventory()
        {
            size = 10;
            maxSize = 100;
            resources = new Dictionary<string, Resource>();
        }
        public Inventory(int size, int maxSize, Dictionary<string, Resource> resources)
        {
            this.size = size;
            this.maxSize = maxSize;
            this.resources = resources;
        }
    }
}
