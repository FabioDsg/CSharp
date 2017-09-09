using System;
using System.Collections.Generic;

namespace ExeSection_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            while (true)
            {
                Console.WriteLine("Type a name or press Enter to exit: ");

                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))

                    break;
                names.Add(input);
            }

            if (names.Count > 2)
                Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
            else if (names.Count == 2)
                Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
            else if (names.Count == 1)
                Console.WriteLine("{0} likes your post.", names[0]);
            else
                Console.WriteLine();
        }

    }
}    

