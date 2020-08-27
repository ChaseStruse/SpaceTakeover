using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTakeover.Data.Models
{
    public class Resource
    {
        private string name;
        private decimal value;
        private int strength;

        public Resource()
        {
            this.name = "Test";
            this.value = 1.0m;
            this.strength = 100;
        }
        public Resource(string name, decimal value, int strength)
        {
            this.name = name;
            this.value = value;
            this.strength = strength;
        }

        public void setName(string _name)
        {
            name = _name;
        }
        public string getName()
        {
            return name;
        }

        public void setValue(decimal _value)
        {
            value = _value;
        }
        public decimal getValue()
        {
            return value;
        }

        public void setStrength(int _strength)
        {
            strength = _strength;
        }
        public int getStrength()
        {
            return strength;
        }
    }
}
