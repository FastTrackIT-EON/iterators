using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    public static class Generators
    {
        public static IEnumerable<int> GenerateAllNumbers()
        {
            int counter = 0;
            while (true)
            {
                yield return counter;
                counter++;
            }
        }

        public static IEnumerable<int> GenerateEvenNumbersTill(int n)
        {
            int counter = 0;
            
            while (counter <= n)
            {
                yield return counter;
                counter += 2;
            }
        }

        
    }
}
