using System;
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
                        Doubler();
                        break;
                    }
                case 3:
                    {
                        Lowercase();
                        break;
                    }
                case 4:
                    {
                        Validator();
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
        static void Doubler()
        {
            Console.WriteLine("Input first string:");
            string firstString = Console.ReadLine();
            StringBuilder outputString = new StringBuilder(firstString);
            Console.WriteLine("Input second string:");
            string secondString = Console.ReadLine();
            char[] charsOfSecondString = secondString.ToCharArray();
            for (int i = 0; i < outputString.Length; i++)
            {
                for (int j = 0; j < charsOfSecondString.Length; j++)
                {
                    if (outputString[i] == charsOfSecondString[j] && !char.IsSeparator(charsOfSecondString[j]))
                    {
                        outputString.Insert(i, charsOfSecondString[j]);
                        i++;
                        break;
                    }
                }
            }
            Console.WriteLine(outputString);
        }
        static void Lowercase()
        {
            Console.WriteLine("Input some string:");
            string inputString = Console.ReadLine();
            Console.WriteLine("Choose variant of task:" + nextString + "1.Separator is spacebar only" + nextString + "2.Separator with differnt separators");
            int chooseSeparatorPart;
            string inputNumberString;
            string[] arrOfStrings = null;
            do
            {
                inputNumberString = Console.ReadLine();
            }
            while (!int.TryParse(inputNumberString, out chooseSeparatorPart));
            switch (chooseSeparatorPart)
            {
                case 1:
                    {
                        arrOfStrings = inputString.Split(' ');
                        break;
                    }
                case 2:
                    {
                        arrOfStrings = inputString.Split(',', '.', ';', ':', ' ');
                        break;
                    }
                default:
                    break;
            }
            int counter = 0;
            for (int i = 0; i < arrOfStrings.Length; i++)
            {
                if (arrOfStrings[i] != "" && Char.IsLower(arrOfStrings[i][0]))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
        static void Validator()
        {
            Console.WriteLine("Input some string:");
            StringBuilder inputSB = new StringBuilder(Console.ReadLine().Trim());
            int counter = 0;
            for (int i = 0; i < inputSB.Length; i++)
            {
                if (inputSB[i] == '.' || inputSB[i] == '?' || inputSB[i] == '!')
                {
                    inputSB[i - counter] = char.ToUpper(inputSB[i - counter]);
                    counter = 0;
                    if (i + 1 != inputSB.Length)
                    {
                        int j = i;
                        while (inputSB[j+1]==' ') // Counting the number of spaces before the beginning of a line
                        {
                            counter--;
                            j++;
                        }
                    }
                }
                else
                {
                    counter++;
                }
            }
            Console.WriteLine(inputSB);
        }
    }
}
