using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3._3._3
{
    class User
    {
        public event EventHandler<List<Pizza>> UserEvent;
        public String Name { get;}
        public User(string name)
        {
            Name = name;
        }

        public void MakeOrder(List<Pizza> pizzaList)
        {
            UserEvent?.Invoke(this, pizzaList);
        }
    }
}
