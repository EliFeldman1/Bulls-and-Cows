using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulls_and_Cows
{
    internal class ErrorControler
    {
        ErrorsClass ErrorsClass = new ErrorsClass();
        public ErrorsModel ErrorsModel(string Number)
        {
            ErrorsModel errorsModel = new ErrorsModel();

            // Here The numbers of the input is testd
            //bool flag = true;
            
            if (ErrorsClass.isit4digits(Number) == true) { errorsModel.Posibile = true; }
            else
            {
                errorsModel.Posibile = false;
                errorsModel.MessageError = " Error !: Enter exactly 4 numbers ";
                return errorsModel;
            }

            if (ErrorsClass.isTheFirstDigit0(Number) == true) { errorsModel.Posibile = true; }
            else
            {
                errorsModel.Posibile = false;
                errorsModel.MessageError = " Error !: The first digit most not be '0' ";
                return errorsModel;
            }

            if (ErrorsClass.isTwoNumbersAreTheSame(Number) == true) { errorsModel.Posibile = true; }
            else
            {
                errorsModel.Posibile = false;
                errorsModel.MessageError = " Error !: Two digits cannot be the same  ";
                return errorsModel;
            }
            return errorsModel;

        }
    }
}
