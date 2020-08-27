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
            name = "Test";
            value = 1.0m;
            strength = 100;
        }

        public Resource(string _name, int _value, int _strength)
        {
            name = _name;
            value = _value;
            strength = _strength;
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
