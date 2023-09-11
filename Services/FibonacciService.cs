using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public sealed class FibonacciService : IFibonacciService
    {
        public FibonacciService() { }
        public int FibonacciSequence(int index)
        {
            return Operation(index);
        }
        private int Operation(int index)
        {
            if (index == 0 || index == 1)
            {
                return index;
            }
            else
            {
                return Operation(index - 1) + Operation(index - 2);
            }
        }
    }
}
