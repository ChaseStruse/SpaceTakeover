using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTakeover.Data.Models
{
    public class Inventory
    {
        private int size;
        private int maxSize;
        List<Resource> resources;

        public Inventory()
        {
            size = 10;
            maxSize = 100;
            resources = new List<Resource>();
        }
        public Inventory(int size, int maxSize, List<Resource> resources)
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

        public List<Resource> getResources()
        {
            return resources;
        }
    }
}
