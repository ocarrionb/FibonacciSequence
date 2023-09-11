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
        public async Task<int> FibonacciSequence(int index)
        {
            int val = 2;
            return val;
        }
    }
}
