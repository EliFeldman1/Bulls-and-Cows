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
            // This function checks if the input has 4 digits
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
            // This function checks if the input first char is 0
            if (Number.StartsWith("0") == true)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public bool isTwoNumbersAreFollow(string Number)
        {
            // This function checks whether the input has two digits  consecutive
            for (int i = 0; i < 3; i++)
            {
                if (Number[i] == Number[i + 1]) 
                { 
                    return false;
                }
            }
                return true;
            

        }
    }
}
