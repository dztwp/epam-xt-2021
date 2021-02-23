using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfTask;
            string enteredString;
            while (true)
            {
                Console.WriteLine("Select task from list: " +
                    "\n 1. RECTANGLE" +
                    "\n 2. TRIANGLE" +
                    "\n 3. ANOTHER TRIANGLE" +
                    "\n 4. X-MAS TREE" +
                    "\n 5. SUM OF NUMBERS" +
                    "\n 6. FONT ADJUSTMENT" +
                    "\n 7. ARRAY PROCESSING" +
                    "\n 8. NO POSITIVE " +
                    "\n 9. NON-NEGATIVE SUM " +
                    "\n 10. 2D ARRAY" +
                    "\n");

                enteredString = Console.ReadLine();
                if (!int.TryParse(enteredString, out numOfTask) || numOfTask < 1 || numOfTask > 8)
                {
                    return;
                }
                switch (numOfTask)
                {
                    case 1:
                        {
                            Console.WriteLine("Area of rectangle is - {0}", GetAreaOfRectangle());
                            break;
                        }
                    case 2:
                        {
                            CreateLeftSideTriangle();
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Enter number of strings - ");
                            string strForNum = Console.ReadLine();
                            int numOfStrings;
                            if (int.TryParse(strForNum, out numOfStrings) && numOfStrings > 0)
                            {
                                CreateTriangle(numOfStrings);
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Enter number of strings - ");
                            string strForNum = Console.ReadLine();
                            int numOfStrings;
                            if (int.TryParse(strForNum, out numOfStrings) && numOfStrings > 0)
                            {
                                CreateXMasTree(numOfStrings);
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.Write("Enter number - ");
                            string strForNum = Console.ReadLine();
                            int enteredNumber;
                            if (int.TryParse(strForNum, out enteredNumber) && enteredNumber > 0 && enteredNumber < 1000)
                            {
                                Console.WriteLine(GetSumOfMultiple(enteredNumber));
                            }
                            break;
                        }
                    default:
                        break;

                }


            }
            Console.ReadKey();

        }

        static string GetAreaOfRectangle()
        {
            Console.Write("Enter side A - ");
            string aString = Console.ReadLine();
            Console.Write("Enter side B - ");
            string bString = Console.ReadLine();
            int a;
            int b;
            if (int.TryParse(aString, out a) && int.TryParse(bString, out b))
            {
                if (a <= 0 || b <= 0)
                {
                    throw new ArgumentException("Sides of rectangle must be positive");
                }
                return (a * b).ToString();
            }
            return "Entered incorrect data";
        }
        static void CreateLeftSideTriangle()
        {
            Console.Write("Enter number of strings - ");
            string enteredString = Console.ReadLine();
            int numOfStrings;
            if (int.TryParse(enteredString, out numOfStrings) && numOfStrings > 0)
            {
                for (int i = 1; i <= numOfStrings; i++)
                {
                    Console.WriteLine(new string('*', i));
                }
            }
        }
        static void CreateTriangle(int numOfStrings)
        {
            int starsCounter = 1;
            for (int i = 1; i <= numOfStrings; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine(new string(' ', numOfStrings - i) + new string('*', starsCounter));
                }
                else
                {
                    Console.WriteLine(new string(' ', numOfStrings - i) + new string('*', starsCounter += 2));
                }

            }
        }
        static void CreateTriangle(int numOfStrings,int indent)
        {
            int starsCounter = 1;
            for (int i = 1; i <= numOfStrings; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine(new string(' ', indent - i) + new string('*', starsCounter));
                }
                else
                {
                    Console.WriteLine(new string(' ', indent - i) + new string('*', starsCounter += 2));
                }

            }
        }

        static void CreateXMasTree(int numOfTriangles)
        {
            for (int i = 1; i < numOfTriangles; i++)
            {
                CreateTriangle(i,numOfTriangles);
            }
        }
        static int GetSumOfMultiple(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                if(i%3==0||i%5==0)
                {
                    sum += i;
                }
            }
            return sum;
        }

    }

}

