using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadanie_1_1.Logic;

namespace zadanie_1_1.Menu
{
    public static class MainMenu
    {
        public static void GetMainMenu()
        {
            bool isContinue = true;
            do
            {
                int changeTask = 0;
                Console.Write("Выберите задание:\n 0) Выход:\n 1) Разделение на разряды:\n Все-остальное) Выдох на себя:\n");
                string elemMenuStr = Console.ReadLine();

                if (!int.TryParse(elemMenuStr, out changeTask))
                    continue;

                if (!Enum.IsDefined(typeof(ElemMainMenu), changeTask))
                    continue;

                switch ((ElemMainMenu)changeTask)
                {
                    case ElemMainMenu.exit:
                        isContinue = false;
                        break;
                    case ElemMainMenu.numberRank:
                        NumberRankMenu.GetNumberRankMenu();
                        break;
                    default:
                        break;
                }

            } while (isContinue);
        }
    }
}
