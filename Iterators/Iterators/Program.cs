using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> array = new List<int> { 1, 2, 3 };
            foreach (int element in array)
            {

            }

            BECOMES:

            IEnumerator<int> enumerator = array.GetEnumerator();
            while(enumerator.MoveNext())
            {
                int element = enumerator.Current;
            }
            */

            ProductManager productManager = new ProductManager();
            productManager.Add(new Product
            {
                Id = 1,
                Name = "Product 123"
            });

            foreach (Product product in productManager)
            {
                Console.WriteLine(product.Name);
            }

            Console.WriteLine(productManager.HasElements());

            Address address = new Address
            {
                Country = "Romania",
                City = "Cluj-Napoca",
                Street = "Onisifor Ghibu",
                PostalCode = "123"
            };


            IEnumerator<string> enumerator = address.GetEnumerator();
            foreach (string addressPart in address)
            {
                Console.WriteLine(addressPart);
            }

            foreach (int evenNumber in Generators.GenerateEvenNumbersTill(10))
            {
                Console.WriteLine(evenNumber);
            }

            IEnumerable<int> allNumbers = Generators.GenerateAllNumbers();
            foreach (int evenNumbers in allNumbers.GetOnlyEvenNumbersTill(10))
            {
                Console.WriteLine(evenNumbers);
            }

            foreach (int number in allNumbers.TakeFirst(5))
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
