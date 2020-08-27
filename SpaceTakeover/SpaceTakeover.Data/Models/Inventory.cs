using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace SpaceTakeover.Data.Models
{
    public class Inventory
    {
        private int size;
        private int maxSize;
        Dictionary<string, Resource> resources;

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

        public void setSize(int _size)
        {
            size = _size;
        }
        public int getSize()
        {
            return size;
        }

        public void setMaxSize(int _maxSize)
        {
            maxSize = _maxSize;
        }
        public int getMaxSize()
        {
            return maxSize;
        }

        public void addResource(Resource resource)
        {
            resources.Add(resource.getName(), resource);
        }
        public Dictionary<string, Resource> getResources()
        {
            return resources;
        }
    }
}
