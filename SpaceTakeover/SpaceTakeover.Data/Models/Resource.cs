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
        private int quantity;

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

        public void setQuantity(int _quantity)
        {
            quantity = _quantity;
        }
        public int getQuantity()
        {
            return quantity;
        }
        public void addToCurrentQuantity(int _quantity)
        {
            quantity += _quantity;
        }
    }
}
