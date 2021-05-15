﻿using System;

namespace zadanie_1_1
{
    class Program
    {
        static void Main()
        {
            int viborZadanii;
            do
            {
                Console.Write("Выберите задание: ");
            } while (!int.TryParse(Console.ReadLine(), out viborZadanii));

            switch (viborZadanii)
            {
                case 1:
                    DelenieNaRazryady();
                    break;

            }
        }
        private static void DelenieNaRazryady()
        {
            int number;
            do
            {
                Console.Write("пятизначное число для деления на разряды ");
            } while (!int.TryParse(Console.ReadLine(), out number));
            if (number >= 0 && number <= 9999 || number > 100000)
            {
                Console.WriteLine("Число должно быть пятизначным");
            }
            else for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(i + 1 + " цифра: " + Convert.ToInt32(number / (Math.Pow(10, (4 - i))) % 10));
                }


            Menu();
        }

        public static void Menu()
        {
            int menu;
            do
            {
                    Console.Write("Че дальше делаем?\n 1)ебани еще раз\n 2)Дай другое задание потыкать\n 3)Выйди нахуй \n");
            } while (!int.TryParse(Console.ReadLine(), out menu));

            
            switch(menu)
            {
                case (1): 
                    DelenieNaRazryady();
                    break;
                case (2):
                   Main();
                    break;
                case (3):
                    break;
            }   

        }
        
    }
} 

