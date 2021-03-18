using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomableStringTool;

namespace Task_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomString str2 = new CustomString("123   124124");
            CustomString str3 = new CustomString("12312343й45");
            CustomString str4 = CustomString.Concat(str2, str3);
            Console.WriteLine(str4[2]);
            Console.ReadKey();


        }
    }
}
