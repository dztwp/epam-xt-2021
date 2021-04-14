using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ll = new List<int>();
            ll.Add(5);
            ll.Add(7);
            ll.Add(6);
            ll.Add(5);
            ll.Add(7);
            ll.Add(6);
            ll.Add(1);
            ll.Add(4);
            MyDynamicArray<int> arr = new MyDynamicArray<int>(ll);
            arr.Remove(5);
            arr.Insert(5, 4);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
                Console.WriteLine(arr[600]);
            }
            arr.Clear();
            
            Console.ReadKey();
        }
    }
}
