using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulls_and_Cows

{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            ErrorControler errorControler = new ErrorControler();
            ErrorsModel errorsModel = new ErrorsModel();
            ChackModel chackModel = new ChackModel();
            ChackClass chackClass = new ChackClass();
            CreateRandNumControler createRandNumControler = new CreateRandNumControler();

            string secretNumber = createRandNumControler.SecretNum();
            int Guess = 0;
            while (Guess < 12)
            {
                
                Console.WriteLine("Enter a number of 4 digits ");

                string inputNumber = Console.ReadLine();
                //Checking whether the entered number meets the conditions.
                errorsModel = errorControler.ErrorsModel(inputNumber);
                if (errorsModel.Posibile == true)
                {
                    chackModel = chackClass.chackModel(inputNumber, secretNumber);
                    Console.WriteLine("You Have " + chackModel.cows + " Cows and " + chackModel.bulls + " Bulls");
                    Guess++;
                }
                else
                {
                    Console.WriteLine(errorsModel.MessageError);
                }
                //bool isIt4Digits = errors.isit4digits(input);
            }


        }
    }
}
