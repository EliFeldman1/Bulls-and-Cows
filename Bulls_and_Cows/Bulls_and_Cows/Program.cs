using ConsoleApp3;
using ConsoleApp3.Model;
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
            // ErrorsClass errors = new ErrorsClass();
            ErrorControler errorControler = new ErrorControler();
            ErrorsModel errorsModel = new ErrorsModel();
            ChackModel chackModel = new ChackModel();
            ChackClass chackClass= new ChackClass();
            string secretNumber = "1234";
            int Guess = 0;
            while (Guess < 12)
            {
                
                Console.WriteLine("Enter a number of 4 digits ");

                string inputNumber = Console.ReadLine();
                errorsModel = errorControler.ErrorsModel(inputNumber);
                if (errorsModel.Posibile == true)
                {
                    chackModel = chackClass.chackModel(inputNumber, secretNumber);
                    Console.WriteLine("You Have "+chackModel.cows +" Cows and "+ chackModel.bulls +" Bulls");
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
