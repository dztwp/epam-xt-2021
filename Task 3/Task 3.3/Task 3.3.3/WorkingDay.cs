using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3._3._3
{
    enum PrintInfoEnum
    {
        StartSession,
        GetPizzaListForOrder,
        GetPizzaName,
        GetPizzaSize
    }
    class WorkingDay
    {
        List<Order> _listOfOrder = new List<Order>();

        private int _numOfOrder = 1;

        private bool _isPizzeriaWorking;

        public WorkingDay()
        {
            StartSession();
        }

        private void StartSession()
        {
            _isPizzeriaWorking = true;
            while (_isPizzeriaWorking)
            {
                PrintInfo(PrintInfoEnum.StartSession);

                switch (GetNumberFromString())
                {
                    case 1:
                        {
                            Order newOrder = CreateOrder();
                            _listOfOrder.Add(newOrder);
                            newOrder.StartTimer(newOrder.PizzasList.Count);
                            Console.WriteLine($"Спасибо за заказ, ваш номер {_numOfOrder}") ;
                            _numOfOrder++;
                            break;
                        }
                    case 987765:
                        {
                            _isPizzeriaWorking = false;
                            break;
                        }
                    default:
                        break;
                }
            }

        }


        public Order CreateOrder() => new Order(new User(_numOfOrder), GetPizzaListForOrder());

        private List<Pizza> GetPizzaListForOrder()
        {
            List<Pizza> tmpListOfPizza = new List<Pizza>();
            do
            {
                tmpListOfPizza.Add(new Pizza(GetPizzaName(), GetPizzaSize()));

                PrintInfo(PrintInfoEnum.GetPizzaListForOrder);
            }
            while (Console.ReadKey().Key != ConsoleKey.D2);

            return tmpListOfPizza;
        }

        private string GetPizzaName()
        {
            PrintInfo(PrintInfoEnum.GetPizzaName);
            while (true)
            {
                switch (GetNumberFromString())
                {
                    case 1:
                        return "Пепперони";
                    case 2:
                        return "Маргарита";
                    case 3:
                        return "Американо";
                    case 4:
                        return "Кальцоне";
                    default:
                        Console.WriteLine("Неправильно выбрана позиция, попробуйте снова");
                        break;
                }
            }
        }

        private string GetPizzaSize()
        {
            PrintInfo(PrintInfoEnum.GetPizzaSize);
            while (true)
            {
                switch (GetNumberFromString())
                {
                    case 1:
                        return "Маленькая";
                    case 2:
                        return "Средняя";
                    case 3:
                        return "Большая";
                    default:
                        Console.WriteLine("Неправильно выбран размер пиццы, попробуйте снова");
                        break;
                }
            }
        }

        private void PrintInfo(PrintInfoEnum variant)
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
                        Console.WriteLine("Для добавления новой позиции нажмите - 1" + Environment.NewLine +
                    "Для выхода из меня выбора нажмите - 2"+Environment.NewLine);
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
                case PrintInfoEnum.GetPizzaSize:
                    {
                        Console.WriteLine("Выберите пиццу:" + Environment.NewLine +
              "1 - Маленькая" + Environment.NewLine +
              "2 - Средняя" + Environment.NewLine +
              "3 - Большая" + Environment.NewLine);
                    }
                    break;
                default:
                    break;
            }
        }
        private static int GetNumberFromString()
        {
            int num;
            while (!int.TryParse(Console.ReadLine(), out num)) ;
            return num;
        }
    }
}
