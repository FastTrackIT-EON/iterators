using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    public class Address : IEnumerable<string>
    {
        public string Country { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string PostalCode { get; set; }

        public IEnumerator<string> GetEnumerator()
        {
            // step 1:
            yield return Country;

            // step 2:
            yield return City;

            // step 3:
            yield return Street;

            // step 4:
            yield return PostalCode;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
