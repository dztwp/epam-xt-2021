using System;

namespace Task_3._3._2
{
    public enum Variants
    {
        Russian,
        English,
        Number,
        Mixed
    }
    class Program
    {

        static void Main(string[] args)
        {
            string s = "12";
            Console.WriteLine(s.GetLanguage());
        }


    }
}
