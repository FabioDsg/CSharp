using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondExercies
{
    class AskNumber
    {
        public void askNumber()
        {



            var resp ="";
            do
            {
                Console.WriteLine("Enter a int number or ok to exit: ");
                resp = Console.ReadLine();

                           
                
            }
            while (resp != "ok");

           
            

        }
    }
}
