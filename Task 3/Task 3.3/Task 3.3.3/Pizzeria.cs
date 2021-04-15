using System;
using System.Collections.Generic;
using System.Text;
using static Task_3._3._3.Program;

namespace Task_3._3._3
{

    class Pizzeria
    {

        private static int _numOfOrder = 1;


        public void CreateOrder(object someUser,List<Pizza> pizzaList)
        {
            Order order = new Order(_numOfOrder++, pizzaList);
            order.StartCooking(order);

        }
        public List<Pizza> GetPizzaListForOrder()
        {
            PrintClass.PrintHelloMessage(_numOfOrder);
            List<Pizza> tmpListOfPizza = new List<Pizza>();
            do
            {
                tmpListOfPizza.Add(GetPizzaFromUserInput());

                PrintClass.PrintInfo(PrintInfoEnum.GetPizzaListForOrder);
            }
            while (Console.ReadKey().Key != ConsoleKey.D1);

            return tmpListOfPizza;
        }

        private Pizza GetPizzaFromUserInput()
        {
            PrintClass.PrintInfo(PrintInfoEnum.GetPizzaName);
            while (true)
            {
                switch (GetNumberFromString())
                {
                    case 1:
                        return new Pizza("Пепперони", 5);
                    case 2:
                        return new Pizza("Маргарита", 6);
                    case 3:
                        return new Pizza("Американо", 8);
                    case 4:
                        return new Pizza("Кальцоне", 3);
                    default:
                        Console.WriteLine("Неправильно выбрана позиция, попробуйте снова");
                        break;
                }
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
