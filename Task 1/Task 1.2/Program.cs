﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._2
{
    class Program
    {
        static string nextString = Environment.NewLine;
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the task " + nextString + "1.Averages" + nextString + "2.Doubler" + nextString + "3.Lowercase" + nextString + "4.Validator");
            int chooseTaskNumber;
            string chooseString;
            do
            {
                chooseString = Console.ReadLine();
            }
            while (!int.TryParse(chooseString, out chooseTaskNumber));
            switch (chooseTaskNumber)
            {
                case 1:
                    {
                        Average();
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                case 4:
                    {
                        break;
                    }

                default: break;
            }
            Console.ReadKey();
        }
        static void Average()
        {
            Console.WriteLine("Input some string:");
            string inputString = Console.ReadLine();
            char[] charSeparator = new char[] { ' ', '.', ',' };
            int sumOfLengths = 0;
            int average = 0;
            string[] arrOfString = inputString.Split(charSeparator, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in arrOfString)
            {
                sumOfLengths += item.Length;
            }
            average = (int)Math.Ceiling((decimal)(sumOfLengths / arrOfString.Length));     //Округление до большего целого
            Console.WriteLine($"Average number of characters is - {average}");
        }
    }
}