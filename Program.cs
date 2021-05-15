using System;

namespace zadanie_1_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Волкам привет, остальным соболезную");
            int viborZadanii;
            do
            {
                Console.Write("Выберите задание:\n 1)Разделение на разряды\n 0)Выдох на себя\n");
            } while (!int.TryParse(Console.ReadLine(), out viborZadanii));

            switch (viborZadanii)
            {
                case 1:
                    DelenieNaRazryady();
                    break;
                case(0):
                    break;
            }
        }
        private static void DelenieNaRazryady()
        {
            int number;
            do
            {
                Console.Write("Пятизначное число для деления на разряды ");
            } while (!int.TryParse(Console.ReadLine(), out number) && number>0);
            if (number >= 0 && number <= 9999 || number > 100000)
            {
                Console.WriteLine("Число должно быть пятизначным");
            }
            else for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(i + 1 + " цифра: " + Math.Abs(Convert.ToInt32(number / (Math.Pow(10, (4 - i))) % 10)));
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

