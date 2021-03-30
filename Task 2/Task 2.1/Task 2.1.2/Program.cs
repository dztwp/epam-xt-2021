using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    class Program
    {
        enum ListOfFigures
        {
            Line,
            Circle,
            Round,
            Ring,
            Rectangle,
            Square,
            Triangle
        }
        enum ListOfUserActions
        {
            Add,
            ShowFigures,
            DeleteAll,
            Exit=-1
        }
        static void Main(string[] args)
        {
            User user1 = new User("Sasha");

            
            while (true)
            {
                Console.WriteLine("0 - Добавить фигуру" + Environment.NewLine +
                             "1 - Показать все фигуры" + Environment.NewLine +
                             "2 - Удалить все фигуры у пользователя" + Environment.NewLine +
                             "-1 - Выйти из программы");
                int numOfAction = StringToInt();
                switch ((ListOfUserActions)numOfAction)
                {
                    case ListOfUserActions.Add:
                        {
                            try
                            {
                                user1.AddFigure(CreateFigure()); //try catch перенести в метод!!!
                            }
                            catch (ArgumentException)
                            {
                                Console.WriteLine("Неправильно выбран номер фигуры");
                            }
                            break;

                        }
                    case ListOfUserActions.ShowFigures:
                        {
                            try
                            {
                                user1.ShowFigures();
                            }
                            catch (NullReferenceException)
                            {
                                Console.WriteLine("У пользователя нет добавленных фигур");
                            }
                            break;

                        }
                    case ListOfUserActions.DeleteAll:
                        {
                            try
                            {
                                user1.DeleteAll();
                            }
                            catch (NullReferenceException)
                            {
                                Console.WriteLine("У пользователя нет добавленных фигур");
                            }
                            break;

                        }
                    case ListOfUserActions.Exit:
                        {
                            return;
                        }
                    default: break;
                }

                Console.ReadKey();
            }
        }
        private static Figure CreateFigure()
        {
            Console.WriteLine("Для добавления фигур нажмите:" + Environment.NewLine +
                              "0 - Line" + Environment.NewLine +
                              "1 - Circle" + Environment.NewLine +
                              "2 - Round" + Environment.NewLine +
                              "3 - Ring" + Environment.NewLine +
                              "4 - Rectangle" + Environment.NewLine +
                              "5 - Square" + Environment.NewLine +
                              "6 - Triangle" + Environment.NewLine);

            int numOfFigure = StringToInt();

            switch ((ListOfFigures)numOfFigure)
            {
                case ListOfFigures.Line:
                    {
                        Figure line = new Line(CreatePoint("A"), CreatePoint("B"));
                        Console.WriteLine(line.ToString());
                        return line;
                    }
                case ListOfFigures.Circle:
                    {
                        Figure circle = new Circle(CreatePoint("A"), InsertRadius("Радиус окружности - "));
                        Console.WriteLine(circle.ToString());
                        return circle;
                    }
                case ListOfFigures.Round:
                    {
                        Figure round = new Round(CreatePoint("A"), InsertRadius("Радиус окружности - "));
                        Console.WriteLine(round.ToString());
                        return round;
                    }
                case ListOfFigures.Ring:
                    {
                        Figure ring = new Ring(CreatePoint("A"), InsertRadius("Внутренний радиус - "), InsertRadius("Внешний радиус - "));
                        Console.WriteLine(ring.ToString());
                        return ring;
                    }
                case ListOfFigures.Rectangle:
                    {
                            Figure rectangle = new Rectangle(CreatePoint("A"), CreatePoint("B"), CreatePoint("C"));
                            Console.WriteLine(rectangle.ToString());
                            return rectangle;
                    }
                case ListOfFigures.Square:
                    {

                        Figure square = new Square(CreatePoint("A"), CreatePoint("B"), CreatePoint("C"));
                        Console.WriteLine(square.ToString());
                        return square;
                    }
                case ListOfFigures.Triangle:
                    {
                        Figure triangle = new Triangle(CreatePoint("A"), CreatePoint("B"), CreatePoint("C"));
                        Console.WriteLine(triangle.ToString());
                        return triangle;
                    }

                default: throw new ArgumentException("Неправильно выбран номер фигуры");
            }
        }
        private static Point CreatePoint(string nameOfPoint)
        {
            Console.WriteLine($"Введите координату X для точки {nameOfPoint}");
            int x = StringToInt();
            Console.WriteLine($"Введите координату Y для точки {nameOfPoint}");
            int y = StringToInt();
            return new Point(x, y);

        }
        private static int StringToInt()
        {
            int numOfFigure;
            while (!int.TryParse(Console.ReadLine(), out numOfFigure))
            {
                Console.WriteLine("Неправильно введено число, попробуйте снова");
            }
            return numOfFigure;
        }
        private static int InsertRadius(string description)
        {
            Console.WriteLine(description);
            return StringToInt();
        }

    }
}
