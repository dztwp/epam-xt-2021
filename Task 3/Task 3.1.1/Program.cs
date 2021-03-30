using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPersons = 0;
            int positionToDelete = 0;
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("Введите N");
                numberOfPersons = GetIntByReadline();
                Console.WriteLine("Введите какой по счету человек человек будет вечеркнут каждый раунд");
                positionToDelete = GetIntByReadline();

                if (numberOfPersons > 0 && positionToDelete > 0 && positionToDelete < numberOfPersons)
                {
                    flag=false;
                }
                else
                {
                    Console.WriteLine("Неправильно введены входные данные, попробуйте снова");
                }
                

            }
            RoundOfPerson session = new RoundOfPerson(numberOfPersons);
            session.RemovePersonsAtPosition(positionToDelete);


            Console.ReadKey();


        }
        private static int GetIntByReadline()
        {
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Введено неверное число, попробуйте снова");
            }
            return n;
        }

    }
}
