using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.Library
{
    public class FibonacciSequence : IEnumerable<long>
    {
        public IEnumerator<long> GetEnumerator()
        {
            yield return 1;

            //for (int i = 1; true; i++)
            //{
            //    yield return i;
            //}                
            long previous = 0;
            long current = 1;
            while (true)
            {
                long next = previous + current;
                previous = current;
                current = next;
                yield return current;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
