using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1_1.Logic
{
    public static class NumberRank
    {
        static NumberRank()
        {
            _number = 0;
        }

        private static int _number { get; set; }
        private static readonly int _maxLength = 5;
        private static readonly int _step = 10;

        public static void SetNumber()
        {
            bool isContinue = true;
            int numberFive;

            do
            {
                Console.Write("Пятизначное число для деления на разряды: ");
                string numberStr = Console.ReadLine();
                if (!int.TryParse(numberStr, out numberFive) || (Convert.ToString(numberFive).Length != 5) || (numberStr[0] == '-'))
                    continue;

                isContinue = false;
            } while (isContinue);

            _number = numberFive;
        }

        public static void ShowNumber()
        {
            if (_number == 0)
            {
                Console.WriteLine("Число не введено!");
                return;
            }

            Console.WriteLine("Введенное число: " + _number);
        }

        public static void ShowNumberRank()
        {
            if (_number == 0)
            {
                Console.WriteLine("Число не введено!");
                return;
            }

            for (int index = (_maxLength - 1), numberCount = 1; index >= 0; index--, numberCount++)
            {
                int currentStep = Convert.ToInt32(Math.Pow(_step, index));
                int currentNumber = _number / currentStep;
                _number = _number % currentStep;

                Console.WriteLine($"{numberCount} цифра: {currentNumber}");
            }
        }
    }
}
