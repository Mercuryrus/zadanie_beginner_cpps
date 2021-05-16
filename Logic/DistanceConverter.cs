using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1_1.Logic
{
    public class DistanceConverter
    {
        static DistanceConverter()
        {
            _distance = 0;
        }

        private static double _distance { get; set; }

        public static void SetDistance()
        {
            bool isContinue = true;
            double distance;

            do
            {
                Console.Write("Расстояние для перевода: ");

                if (double.TryParse(Console.ReadLine(), out distance) && distance >= 0)
                {
                    isContinue = false;
                    _distance = distance;
                }
                    continue;
                    
                
            } while (isContinue);
        }

        public static void ShowDistance()
        {
            if (_distance < 0)
            {
                Console.WriteLine("Дистанция не может быть отрицательной!\n");
                return;
            }

            Console.WriteLine("Введенное расстояние: " + _distance + " м.\n");
        }

        public static void ShowConvertedDistanceCM()
        {
            if (_distance < 0)
            {
                Console.WriteLine("Расстояние не может быть отрицательным!\n");
                return;
            }
            else
            {
                _distance = _distance * 100;
                Console.WriteLine("Расстояние в сантиметрах: " + _distance + " см.\n");

            }
        }
        public static void ShowConvertedDistanceKM()
        {
            if (_distance < 0)
            {
                Console.WriteLine("Расстояние не может быть отрицательным!\n");
                return;
            }
            else
            {
                _distance = _distance / 1000;
                Console.WriteLine("Расстояние в километрах: " + _distance + " км.\n");
            }

        }
    }
}
