using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class EachExample
    {
        public void foreachExample()
        {
            // Using foreach
            var name = "John Smith";
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            // Another example 
            var numbers = new int[] { 1, 2, 3, 4 };

            foreach (var number in numbers)

            {
                Console.WriteLine(number);
            }
        }
    }
}
