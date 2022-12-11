using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulls_and_Cows
{
    internal class ErrorsClass
    {

        

            public bool isit4digits(int Number)
            {
            bool Posibile;
           string number=Convert.ToString(Number);
            if (number.Length == 4)
                {
                    Posibile = true;
                }
                else
                {
               Posibile = false;
    
            }
                return Posibile;
            }
        
    }
}
