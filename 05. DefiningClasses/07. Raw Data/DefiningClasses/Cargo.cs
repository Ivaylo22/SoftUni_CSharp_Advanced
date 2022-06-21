using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Cargo
    {
        private double weight;
        private string type;

        public Cargo()
        {
        }

        public Cargo(double weight, string type)
        {
            this.weight = weight;
            this.type = type;
        }

        public double Weight 
        { 
            get { return weight; }
            set { weight = value; }
        }

        public string Type 
        {
            get { return type; } 
            set { type = value; }
        }
    }
}
