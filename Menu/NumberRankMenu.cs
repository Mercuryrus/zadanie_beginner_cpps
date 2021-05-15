using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadanie_1_1.Logic;

namespace zadanie_1_1.Menu
{
    public static class NumberRankMenu
    {
        public static void GetNumberRankMenu()
        {
            bool isContinue = true;
            do
            {
                int changeTask = 0;
                Console.Write("Выберите пункт меню:\n 0) Выход:\n 1) Ввести число:\n 2) Показать введенно число: \n 3) Показать жопу: \n Все-остальное) Выдох на себя:\n");
                string elemMenuStr = Console.ReadLine();

                if (!int.TryParse(elemMenuStr, out changeTask))
                    continue;

                if (!Enum.IsDefined(typeof(ChangeElemMenu), changeTask))
                    continue;

                switch ((ChangeElemMenu)changeTask)
                {
                    case ChangeElemMenu.exit:
                        isContinue = false;
                        break;
                    case ChangeElemMenu.setNumber:
                        NumberRank.SetNumber();
                        break;
                    case ChangeElemMenu.showNumber:
                        NumberRank.ShowNumber();
                        break;
                    case ChangeElemMenu.showNumberRank:
                        NumberRank.ShowNumberRank();
                        break;
                    default:
                        break;
                }

            } while (isContinue);
        }
    }

    public enum ChangeElemMenu
    {
        exit = 0,

        setNumber = 1,
        showNumber = 2,
        showNumberRank = 3,
    }
}
