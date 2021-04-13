using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._1._2
{
    class TextAnalyzer
    {
        private string _analyzedString;
        Dictionary<string, int> _occurenceOfStrings = new Dictionary<string, int>();
        public TextAnalyzer(string inputedString)
        {
            _analyzedString = inputedString;
        }

        private string[] GetArrOfWords()
        {
            char[] separators = { ',', '.', ' ', '!', '?', ';' };
            return _analyzedString.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        }

        public void AnalyzeText()//StartAnalyze(3 Метода внутри)
        {
            string[] arrOfWords = GetArrOfWords();
            for (int i = 0; i < arrOfWords.Length; i++)
            {
                if (_occurenceOfStrings.ContainsKey(arrOfWords[i].ToLower()))
                {
                    _occurenceOfStrings[arrOfWords[i].ToLower()]++;
                }
                else
                {
                    _occurenceOfStrings.Add(arrOfWords[i].ToLower(), 1);
                }
            }
            PrintAnalysis(_occurenceOfStrings);
            PrintMostUsableWords(_occurenceOfStrings);

        }

        private void PrintAnalysis(Dictionary<string, int> inputData)
        {
            Console.WriteLine("Слово - количество");
            foreach (var pair in inputData.OrderByDescending(pair => pair.Value))
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }
        }
        private void PrintMostUsableWords(Dictionary<string, int> inputData)
        {
            int averageValue = GetSumOfDictionaryValues(_occurenceOfStrings) / inputData.Count;
            Console.WriteLine("Слова которые встречается чаще других:");
            foreach (var item in inputData.OrderByDescending(item => item.Value))
            {
                if (item.Value > averageValue * 2)
                {
                    Console.WriteLine($"{item.Key} - {item.Value}");
                }
                else return;
            }
        }
        private int GetSumOfDictionaryValues(Dictionary<string, int> inputData)
        {
            int sum = 0;
            foreach (var item in inputData)
            {
                sum += item.Value;
            }
            return sum;
        }


    }
}
