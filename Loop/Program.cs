using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Uncomment the choice method.
namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            var ex1 = new ForExample();
            var ex2 = new EachExample();
            var ex3 = new WhileExample();
            
            //ex1.forExample();
            //ex2.foreachExample();
            ex3.whileExample();  
        }
    }
}
