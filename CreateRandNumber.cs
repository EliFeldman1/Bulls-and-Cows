using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulls_and_Cows
{
    internal class CreateRandNumber
    {
        private static readonly Random getrandom = new Random();

        public static string GetRandomNumber()
        {
            lock (getrandom) // synchronize
            {
                return Convert.ToString(getrandom.Next(1023,9876));
            }
        }

    }
}
