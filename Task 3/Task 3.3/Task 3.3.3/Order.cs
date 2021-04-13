using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Task_3._3._3
{

    class Order
    {
        public bool IsOrderRecieved{ get; set; }

        private Timer _timer;
        public bool IsDone { get; set; }
        public User Customer { get;}
        public List<Pizza> PizzasList { get; set; }

        public Order(User name, List<Pizza>listOfPizza)
        {
            Customer = name;
            PizzasList = listOfPizza;
            IsDone = false;
        }
        public void StartTimer(int multiply)
        {
             _timer = new Timer();
            _timer.Interval = 5000*multiply;
            _timer.Elapsed += OnTimedEvent;
            _timer.Start();
        }
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            _timer.Stop();
            IsDone = true;
            Console.WriteLine($"Заказ покупателя {Customer.NumberOfOrder} готов");                   
        }
    }
}
