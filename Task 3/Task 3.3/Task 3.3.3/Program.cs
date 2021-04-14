using System;
using System.Collections.Generic;

namespace Task_3._3._3
{
    class Program
    {
        public enum PrintInfoEnum
        {
            StartSession,
            GetPizzaListForOrder,
            GetPizzaName
        }

        static void Main(string[] args)
        {
            Pizzeria pizzeria = new Pizzeria();
            User user1 = new User("Юрий");
            User user2 = new User("Геннадий");

            user1.UserEvent += pizzeria.CreateOrder;
            user2.UserEvent += pizzeria.CreateOrder;
            user1.MakeOrder(pizzeria.GetPizzaListForOrder());
            user2.MakeOrder(pizzeria.GetPizzaListForOrder());
        }

       
    }
}
