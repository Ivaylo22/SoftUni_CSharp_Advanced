using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._Box_of_String
{
    public class Box<T>
    {
        public Box(T element) 
        { 
            Element = element;
        }
        public T Element { get; set; }

        public override string ToString()
        {
            return $"{typeof(T)}: {Element}";
        }
    }
}
