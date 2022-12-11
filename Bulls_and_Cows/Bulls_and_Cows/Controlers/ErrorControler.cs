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
        public ErrorsModel ErrorsModel(int Number)
        {
            ErrorsModel errorsModel = new ErrorsModel();

            // Here The numbers of the input is testd
            if (ErrorsClass.isit4digits(Number) == true) { errorsModel.Posibile = true;}
            else
            {
                errorsModel.Posibile = false;
                errorsModel.MessageError = " Error: Enter exactly 4 numbers ";
            }
            return errorsModel;
        }
    }
}
