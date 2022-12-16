using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    public class GenericsMax<T> where T : IComparable
    {
        public T firstValue;
        public T secondValue;
        public T thirdValue;
        public GenericsMax(T firstValue, T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }
        public T TestMaximum()
        {
            if (this.firstValue.CompareTo(this.secondValue) > 0 && this.firstValue.CompareTo(this.thirdValue) > 0 ||
                this.firstValue.CompareTo(this.secondValue) >= 0 && this.firstValue.CompareTo(this.thirdValue) > 0 ||
                this.firstValue.CompareTo(this.secondValue) > 0 && this.firstValue.CompareTo(this.thirdValue) >= 0)
            {
                return this.firstValue;
            }

            if (secondValue.CompareTo(this.firstValue) > 0 && this.secondValue.CompareTo(this.thirdValue) > 0 ||
                secondValue.CompareTo(this.firstValue) >= 0 && this.secondValue.CompareTo(this.thirdValue) > 0 ||
                secondValue.CompareTo(this.firstValue) > 0 && this.secondValue.CompareTo(this.thirdValue) >= 0)
            {
                return this.secondValue;
            }

            if (this.thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(this.secondValue) > 0 ||
                this.thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(this.secondValue) > 0 ||
                this.thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(this.secondValue) >= 0)
            {
                return this.thirdValue;
            }
            throw new Exception("firstNumber,secondNumber and thirdNumber are same");
        }
    }
}
