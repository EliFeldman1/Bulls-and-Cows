using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulls_and_Cows
{
    internal class ErrorsClass
    {

        

            public bool isit4digits(string Number)
            {
            //bool Posibile;
         //  string number=Convert.ToString(Number);
            if (Number.Length == 4)
                {
                return  true;
                }
                else
                {
                return false;
    
            }
                ;
            }
        public bool isTheFirstDigit0(string Number)
        {
            //bool Posibile;
           // string number = Convert.ToString(Number);
            if (Number.StartsWith("0")== true)
            {
                return false;
            }
            else
            {
                return true;
            }
             
        }
    }
}
