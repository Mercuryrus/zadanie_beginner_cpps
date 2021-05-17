using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadanie_1_1.Logic;

namespace zadanie_1_1.Menu
{
    public static class DistanceConverterMenu
    {
        public static void GetDisatnceConverterMenu()
        {
            bool isContinue = true;
           
            do
            {
                int changeTask = 0;
                var key = Console.ReadKey();
                Console.Write("Выберите пункт меню:\n 0) Выход:\n 1) Ввести расстояние:\n 2) Показать введенное расстояние: \n 3) Перевести в сантиметры" +
                    "\n  4)Перевести в км: \n Все-остальное) Выдох на себя:\n");
                string elemMenuStr = Console.ReadLine();

                if (!int.TryParse(elemMenuStr, out changeTask))
                continue; Console.ReadKey(true);

                if (!Enum.IsDefined(typeof(ChangeElemDistanceMenu), changeTask)) { Console.ReadKey(true); }
                    continue;
                                   
                
                switch ((ChangeElemDistanceMenu)changeTask)
                {
                    case ChangeElemDistanceMenu.exit:
                        isContinue = false;
                        break;
                    case ChangeElemDistanceMenu.setDistance:
                        DistanceConverter.SetDistance();
                        break;
                    case ChangeElemDistanceMenu.showDistance:
                        DistanceConverter.ShowDistance();
                        break;
                    case ChangeElemDistanceMenu.showConvertedDistanceCM:
                        DistanceConverter.ShowConvertedDistanceCM();
                        break;
                    case ChangeElemDistanceMenu.showConvertedDistanceKM:
                        DistanceConverter.ShowConvertedDistanceKM();
                        break;
                    default:
                        break;
                }

            } while (isContinue);
        }


        public enum ChangeElemDistanceMenu
        {
            exit = 0,

            setDistance = 1,
            showDistance = 2,
            showConvertedDistanceCM = 3,
            showConvertedDistanceKM = 4
        }
    }
}
