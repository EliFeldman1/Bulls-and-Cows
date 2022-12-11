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
            ErrorsModel errorsModel= new ErrorsModel(); 

            bool Right = false;
            while (Right == false)
            {
                
                Console.WriteLine("Enter a number of 4 digits ");

                int input = Convert.ToInt32(Console.ReadLine());
                errorsModel= errorControler.ErrorsModel(input);
                int H = 5;
                //bool isIt4Digits = errors.isit4digits(input);
            }

            var m = Console.ReadLine();
            Console.WriteLine(m);
            var h = Console.ReadLine();
        }
    }
}
