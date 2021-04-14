using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using System.Linq;

namespace Task_3._3._3
{

    class Order
    {
        public bool IsOrderRecieved{ get; set; }

        private Timer _timer;
        public int NumOfOrder { get; }
        public List<Pizza> PizzasList { get; set; }

        public Order(int numberOfOrder, List<Pizza>listOfPizza)
        {
            NumOfOrder = numberOfOrder;
            PizzasList = listOfPizza;
        }
        public void StartCooking(Order someOrder)
        {
             _timer = new Timer();
            _timer.Interval = someOrder.PizzasList.Sum(x=>x.TimeForCooking)*someOrder.PizzasList.Count*500;
            _timer.Elapsed += OnTimedEvent;
            _timer.Start();
        }
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            _timer.Stop();
            Console.WriteLine($"Заказ покупателя {NumOfOrder} готов");                   
        }
    }
}
