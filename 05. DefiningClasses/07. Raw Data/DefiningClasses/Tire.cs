using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Tire
    {
        private int age;
        private double presure;

        public Tire()
        {
        }

        public Tire(int age, double presure)
        {
            this.age = age;
            this.presure = presure;
        }

        public int Age 
        { 
            get { return age; }
            set { age = value; }
        }

        public double Presure
        { 
            get { return presure; }
            set { presure = value; }
        }
    }
}
