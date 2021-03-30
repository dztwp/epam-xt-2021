using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._1._1
{
    class RoundOfPerson
    {
        int _constantPosition = 0;
        int _roundCounter = 0;
        private List<Person> _listOfPerson = new List<Person>();

        public RoundOfPerson(int n)
        {
            AddPersons(n);
        }

        private void AddPersons(int numberOfPersons)
        {
            for (int i = 1; i <= numberOfPersons; i++)
            {
                _listOfPerson.Add(new Person(i));
            }
        }
        public void RemovePersonsAtPosition(int numOfDeleted)
        {
            _constantPosition = --numOfDeleted;

            RecursionDelete(_constantPosition);
        }

        private void RecursionDelete(int positionToDelete)
        {
            if (_roundCounter != 0)
            {
                PrintInfoAboutRound();
            }
            if (_listOfPerson.Count > _constantPosition)
            {
                _roundCounter++;

                if (positionToDelete >= _listOfPerson.Count)
                {
                    _listOfPerson.RemoveAt(positionToDelete - _listOfPerson.Count);
                    RecursionDelete(positionToDelete - _listOfPerson.Count - 1 + _constantPosition);
                }
                else
                {
                    _listOfPerson.RemoveAt(positionToDelete);
                    RecursionDelete(positionToDelete + _constantPosition);
                }
            }
            else
            {
                PrintEndMessage();
                return;

            }
        }

        private void PrintInfoAboutRound()
        {
            Console.WriteLine($"Раунд  {_roundCounter}" + $" Вычеркнут человек. Людей осталось: {_listOfPerson.Count}");
        }
        private void PrintEndMessage()
        {
            Console.WriteLine("Игра окончена. Невозможно вычеркнуть больше людей.");
        }


    }
}
