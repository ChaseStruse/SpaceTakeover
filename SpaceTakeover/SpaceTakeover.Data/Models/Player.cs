using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTakeover.Models
{
    public class Player
    {
        protected string name;
        public Player()
        {
            name = "test";
        }

        public void setName(string _name)
        {
            name = _name;
        }
        public string getName()
        {
            return name;
        }
    }
}
