using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Task_3._3._1
{
    public static class IntArrExpander
    {

        public static void DoActionOnElementOfArray<T>( this T[] array, Func<T, T> processor) where T : struct
        {
            if (processor == null)
            {
                throw new ArgumentNullException();
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = processor.Invoke(array[i]);
            }
        }

        public static int GetSum(this int[] inArray)
        {
            return inArray.Sum();
        }
        public static short GetSum(this short[] inArray)
        {
            short sum = 0;
            for (int i = 0; i < inArray.Length; i++)
            {
                sum += inArray[i];
            }
            return sum;
        }

        public static int GetAverage(this int[] inArray)
        {
            return (int)inArray.Average();
        }
        public static short GetAverage(this short[] inArray)
        {
            return (short)(GetSum(inArray) /inArray.Length);
        }

        public static T GetMostPepetitive<T>(this T[] inArray) where T : struct
        {
            return inArray.GroupBy(x => x).OrderByDescending(x => x.Count()).FirstOrDefault().Key;
        }
    }
}
