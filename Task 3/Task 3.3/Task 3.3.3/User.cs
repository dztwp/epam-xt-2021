using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3._3._3
{
    class User
    {
        public int NumberOfOrder { get;}
        public bool IsOrderGetted { get; set; }
        public User(int numOfOrder)
        {
            NumberOfOrder = numOfOrder;
            IsOrderGetted = false;
        }
    }
}
