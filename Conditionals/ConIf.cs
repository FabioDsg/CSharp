using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class ConIf
    {
        bool isGoldCustomer = true;

        public  float customer()
        {
            float price;

            if (isGoldCustomer)
                price = 19.95f;
            else
                price = 29.95f;
            return price;
                        
        }
        

        //float price = (isGoldCustomer) ? 19.95f : 29.95f;


    }
}
