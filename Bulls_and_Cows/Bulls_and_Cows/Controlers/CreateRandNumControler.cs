using ConsoleApp3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulls_and_Cows
{
    internal class CreateRandNumControler:ErrorsClass
    {
        public String SecretNum()
        {
            CreateRandNumber createRandNumber = new CreateRandNumber();
            SecretNumberMosel SecretNumberMosel = new SecretNumberMosel();
            bool flag = false;
            while (flag == false) { 
           
                SecretNumberMosel.Number = CreateRandNumber.GetRandomNumber();
                flag=isTwoNumbersAreTheSame(SecretNumberMosel.Number);
            }
            return SecretNumberMosel.Number;
        }


        CreateRandNumber createRandNumber = new CreateRandNumber();
       // ErrorsClass errorsClass = new ErrorsClass();
        
       
    }
}
