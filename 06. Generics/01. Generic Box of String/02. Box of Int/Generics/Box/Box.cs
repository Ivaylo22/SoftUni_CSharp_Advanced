using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    public class Box<T> : IComparable<T> where T : IComparable<T>
    {
        public Box(T element)
        {
            Element = element;
        }

        public Box(List<T> elementsList)
        {
            Elements = elementsList;
        }

        public T Element { get; set; }

        public List<T> Elements { get; set; }

        public int CompareTo(T other)
            => Element.CompareTo(other);

        public int CountOfGreater<T>(List<T> list, T readline) where T : IComparable =>
            list.Count(word => word.CompareTo(readline) > 0);

        public void Swap(List<T> elements, int indexOne, int indexTwo)
        {
            T firestEl = elements[indexOne];
            elements[indexOne] = elements[indexTwo];
            elements[indexTwo] = firestEl;
        }

        public override string ToString()
        {

            var sb = new StringBuilder();
            foreach (var element in Elements) 
            {  
                sb.AppendLine($"{element.GetType()}: {element}");
            }
            return sb.ToString();
        }

        
    }
}
