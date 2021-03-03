using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1
{
    class Program
    {
        static string nextStr = Environment.NewLine;
        static void Main(string[] args)
        {
            int numOfTask;
            string enteredString;

            while (true)
            {
                Console.WriteLine("Select task from list: " +
                    nextStr + " 1. RECTANGLE" +
                    nextStr + " 2. TRIANGLE" +
                    nextStr + " 3. ANOTHER TRIANGLE" +
                    nextStr + " 4. X-MAS TREE" +
                    nextStr + " 5. SUM OF NUMBERS" +
                    nextStr + " 6. FONT ADJUSTMENT" +
                    nextStr + " 7. ARRAY PROCESSING" +
                    nextStr + " 8. NO POSITIVE " +
                    nextStr + " 9. NON-NEGATIVE SUM " +
                    nextStr + " 10. 2D ARRAY" +
                    nextStr + "");

                enteredString = Console.ReadLine();
                if (!int.TryParse(enteredString, out numOfTask))
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
                    case 6:
                        {
                            FontAdustment();
                            break;
                        }
                    case 7:
                        {
                            ArrayProcessing();
                            break;
                        }
                    case 8:
                        {
                            NoPositive();
                            break;
                        }
                    case 9:
                        {
                            NonNegativeSum();
                            break;
                        }
                    case 10:
                        {
                            GetSumOfEvenNumber();
                            break;
                        }
                    default: continue;
                }


            }
            Console.ReadKey();

        }


        private static void PrintArr(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        private static void PrintArr(string[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        private static void PrintTwoDimensionalArr(int numOfThirdDimension, int[,,] arr)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.WriteLine();
                for (int k = 0; k < arr.GetLength(2); k++)
                {
                    Console.Write(arr[numOfThirdDimension, j, k] + " ");
                }
            }
        }
        private static void PrintTwoDimensionalArr(int[,] arr)
        {
            for (int j = 0; j < arr.GetLength(0); j++)
            {
                for (int k = 0; k < arr.GetLength(1); k++)
                {
                    Console.Write(arr[j, k] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

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
        static void CreateTriangle(int numOfStrings, int indent)
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
                CreateTriangle(i, numOfTriangles);
            }
        }
        static int GetSumOfMultiple(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        static void FontAdustment()
        {
            string[] arr = new string[3];
            while (true)
            {
                int enteredNumber;
                Console.Write("Параметры надписи: ");
                PrintArr(arr);
                Console.WriteLine("Введите: " + nextStr +
                    "    1:bold " + nextStr +
                    "    2:italic " + nextStr +
                    "    3:underline " + nextStr);
                string strForNum = Console.ReadLine();
                if (int.TryParse(strForNum, out enteredNumber))
                {
                    switch (enteredNumber)
                    {
                        case 1:
                            {
                                arr[0] = (arr[0] != null && arr[0] == "bold") ? default(string) : "bold";
                                break;
                            }
                        case 2:
                            {
                                arr[1] = (arr[1] != null && arr[1] == "italic") ? default(string) : "italic";
                                break;
                            }
                        case 3:
                            {
                                arr[2] = (arr[2] != null && arr[2] == "underline") ? default(string) : "underline";
                                break;
                            }

                        default: continue;
                    }


                }
            }
        }

        private static void ArrayProcessing()
        {
            int lengthOfArr;
            string enteredString;
            Random r = new Random();
            do
            {
                Console.Write("Enter the number of array elements - ");
                enteredString = Console.ReadLine();
            }
            while (!int.TryParse(enteredString, out lengthOfArr));
            int[] arr = new int[lengthOfArr];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(-30, 30);
            }
            PrintArr(arr);
            Console.WriteLine("Minumum number is - {0}", GetMin(arr));
            Console.WriteLine("Maximum number is - {0}", GetMax(arr));
            int[] sortedArr = SortArray(arr);
            PrintArr(sortedArr);
        }
        private static int[] SortArray(int[] arr)
        {
            int tmp = 0;
            int[] returnableArr = arr;
            for (int i = 0; i < returnableArr.Length; i++)
            {
                for (int j = 1; j < returnableArr.Length; j++)
                {
                    if (arr[j - 1] > returnableArr[j])
                    {
                        tmp = returnableArr[j];
                        returnableArr[j] = returnableArr[j - 1];
                        returnableArr[j - 1] = tmp;
                    }
                }
            }
            return returnableArr;
        }
        private static int GetMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    max = arr[i];
                }
            }
            return max;
        }
        private static int GetMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[i - 1])
                {
                    min = arr[i];
                }
            }
            return min;
        }
        private static void NoPositive()
        {
            int lengthOfArr;
            string enteredString;
            Random r = new Random();
            do
            {
                Console.Write("Enter the number of array elements - ");
                enteredString = Console.ReadLine();
            }
            while (!int.TryParse(enteredString, out lengthOfArr));
            int[,,] arr = new int[lengthOfArr, lengthOfArr, lengthOfArr];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        arr[i, j, k] = r.Next(-30, 30);
                    }
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                PrintTwoDimensionalArr(i, arr);
            }
            Console.WriteLine();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        if (arr[i, j, k] > 0)
                        {
                            arr[i, j, k] = 0;
                        }
                    }
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                PrintTwoDimensionalArr(i, arr);
            }
            Console.WriteLine();

        }
        private static void NonNegativeSum()
        {
            int lengthOfArr;
            int sum = 0;
            string enteredString;
            Random r = new Random();
            do
            {
                Console.Write("Enter the number of array elements - ");
                enteredString = Console.ReadLine();
            }
            while (!int.TryParse(enteredString, out lengthOfArr));
            int[] arr = new int[lengthOfArr];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(-30, 30);
            }
            PrintArr(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine("Sum of non-positive number is - {0}", sum);

        }
        private static void GetSumOfEvenNumber()
        {
            int lengthOfArr;
            int sum = 0;
            string enteredString;
            Random r = new Random();
            do
            {
                Console.Write("Enter the number of array elements - ");
                enteredString = Console.ReadLine();
            }
            while (!int.TryParse(enteredString, out lengthOfArr));
            int[,] arr = new int[lengthOfArr, lengthOfArr];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = r.Next(-10, 10);
                }
            }
            PrintTwoDimensionalArr(arr);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            Console.WriteLine("Sum of even number is - {0}", sum);
        }

    }
}
