using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3._3._2
{
    public static class StringExtender
    {
        public static Variants GetLanguage(this string inputString)
        {
            inputString = inputString.ToLower();

            if (DoActionOnElementOfArray(inputString, IsRussian))
            {
                return Variants.Russian;
            }
            else if (DoActionOnElementOfArray(inputString, IsEnglish))
            {
                return Variants.English;
            }
            else if (DoActionOnElementOfArray(inputString, x=>char.IsNumber(x)))
            {
                return Variants.Number;
            }
            else
            {
                return Variants.Mixed;
            }             

        }
        private static bool IsRussian(this char symbol)
        {
            return ((symbol >= 'а') && (symbol <= 'я') || symbol == 'ё') ? true : false;
        }
        private static bool IsEnglish(this char symbol)
        {
            return (symbol >= 'a' && symbol <= 'z') ? true : false;
        }
        private static bool DoActionOnElementOfArray(this string inString, Func<char, bool> processor)
        {
            if (processor == null)
            {
                throw new ArgumentNullException();
            }
            for (int i = 0; i < inString.Length; i++)
            {
                if (!processor.Invoke(inString[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
