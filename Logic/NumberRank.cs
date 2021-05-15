using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1_1.Logic
{
    public static class NumberRank
    {
        private static int _number { get; set; }

        public static void SetNumber()
        {
            int number;
            
            do
            {
                Console.Write("Пятизначное число для деления на разряды: ");
            } while (!int.TryParse(Console.ReadLine(), out number));


        }
    }
}
