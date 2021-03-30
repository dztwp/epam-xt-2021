using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._1._1
{
    class Person
    {
        private int _number;

        public int Number
        {
            get { return _number; }
        }

        public Person(int n)
        {
            _number = n;
        }
    }
}
