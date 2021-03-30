using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            TextAnalyzer analysis = new TextAnalyzer(Console.ReadLine());
            analysis.AnalyzeText();
            Console.ReadKey();

        }

        
    }
}
