using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    public class Tuple<TFirst, TSecond, TThird>
    {
        public TFirst FirstElement { get; set; }
        public TSecond SecondElement{ get; set; }
        public TThird ThirdElement { get; set; }

        public Tuple(TFirst firstElement, TSecond secondElement, TThird thirdElement)
        {
            FirstElement = firstElement;
            SecondElement = secondElement;
            ThirdElement = thirdElement;
        }

        public override string ToString()
        {
            return $"{FirstElement} -> {SecondElement} -> {ThirdElement}";
        }
    }
}
