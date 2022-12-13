using ConsoleApp3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class ChackClass
    {

        public ChackModel chackModel(string inputNumber,string secretNumber)
        {
            ChackModel chackModel = new ChackModel();
            //Step one count the number of the bulls
            for (int i = 0; i < 4; i++)
            {
                if (inputNumber[i] == secretNumber[i])
                {
                    chackModel.cows++;
                }
            }
            // Step two count the number of the cows
            for (int i = 0; i < 4; i++)
            {
                for (int ii = 0; ii < 4; ii++)
                {
                    if (ii == i) { }
                    else { 
                    if (inputNumber[i] == secretNumber[ii])
                    {
                        chackModel.bulls++;
                    }
                    }
                }

            }
            return chackModel;
        }
    }
}
