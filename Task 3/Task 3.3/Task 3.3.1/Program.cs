using System;


namespace Task_3._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = { 1, 2, 5, 6, 7, 4, 1, 5,5, 7, 8, 11 };
            arr.DoActionOnElementOfArray(x => x * x);
            Console.WriteLine(arr.DoActionOnArray(IntArrExpander.GetSum));
            Console.WriteLine(arr.DoActionOnArray(IntArrExpander.GetAverage));
            Console.WriteLine(arr.DoActionOnArray(IntArrExpander.GetMostPepetitive));
        }
       
    }
}
