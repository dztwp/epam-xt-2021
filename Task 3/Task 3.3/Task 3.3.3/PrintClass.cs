using System;
using System.Collections.Generic;
using System.Text;
using static Task_3._3._3.Program;

namespace Task_3._3._3
{
    static class PrintClass
    {
        public static void PrintInfo(PrintInfoEnum variant)
        {
            switch (variant)
            {
                case PrintInfoEnum.StartSession:
                    {
                        Console.WriteLine("Добро пожаловать!" + Environment.NewLine +
                    "Чтобы сделать заказ нажмите - 1");
                    }
                    break;
                case PrintInfoEnum.GetPizzaListForOrder:
                    {
                        Console.WriteLine("Для добавления новой позиции нажмите любую кнопку" + Environment.NewLine +
                    "Для выхода из меню выбора нажмите - 1" + Environment.NewLine);
                    }
                    break;
                case PrintInfoEnum.GetPizzaName:
                    {
                        Console.WriteLine("Выберите пиццу:" + Environment.NewLine +
                "1 - Пепперони" + Environment.NewLine +
                "2 - Маргарита" + Environment.NewLine +
                "3 - Американо" + Environment.NewLine +
                "4 - Кальцоне" + Environment.NewLine);
                    }
                    break;
                default:
                    break;
            }
        }
        public static void PrintHelloMessage(int num)
        {
            Console.WriteLine($"Добро пожаловать, клиент №{num}");
        }
    }
}
