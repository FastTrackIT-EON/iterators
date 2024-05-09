using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<int> GetOnlyEvenNumbersTill(
            this IEnumerable<int> source,
            int n)
        {
            foreach (int number in source)
            {
                if (number <= n)
                {
                    if (number % 2 == 0)
                    {
                        yield return number;
                    }
                }
                else
                {
                    yield break;
                }
            }
        }

        public static IEnumerable<int> TakeFirst(
            this IEnumerable<int> source, int count)
        {
            int counter = 0;
            foreach (int number in source)
            {
                if (counter < count)
                {
                    yield return number;
                    counter++;
                }
                else
                {
                    yield break;
                }
            }
        }

        public static bool HasElements<T>(
            this IEnumerable<T> source)
        {
            return source.GetEnumerator().MoveNext();
        }
    }
}
