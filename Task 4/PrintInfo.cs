using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_4
{
    public enum TypesOfErrors
    {
        InputedWrongFolderName,
        InputedNotANumberString
    }
    public enum IntroductoryText
    {
        ModeChoosing,
        PressEscapeForExit,
        TheRollbackWasSuccessfull,
        ChooseFolderForRollback
    }
    public static class PrintInfo
    {
        public static void PrintInfoAboutEvents(EventTypes events, params string[] nameOfFile)
        {
            switch (events)
            {
                case EventTypes.OnRename:
                    {
                        Console.WriteLine($"Файл {nameOfFile[1]} был переименован в {nameOfFile[0]}");
                    }
                    break;
                case EventTypes.OnChange:
                    {
                        Console.WriteLine($"Файл {nameOfFile[0]} был изменен");
                    }
                    break;
                case EventTypes.OnCreate:
                    {
                        Console.WriteLine($"Создан новый файл - {nameOfFile[0]}");
                    }
                    break;
                case EventTypes.OnDelete:
                    {
                        Console.WriteLine($"Удален файл - {nameOfFile[0]}");
                    }
                    break;
                default:
                    break;
            }
        }
        public static void PrintListOfHiddenFolders(DirectoryInfo[] listOfFolders)
        {
            Console.WriteLine("Список существующих бэкапов:");
            foreach (var folder in listOfFolders)
            {
                Console.WriteLine(folder.Name);
            }
        }
        public static void PrintErrorInConsole(TypesOfErrors err)
        {
            switch (err)
            {
                case TypesOfErrors.InputedWrongFolderName:
                    {
                        Console.WriteLine("Неправильно введена дата для отката к предыдущей версии, попробуйте снова");
                        break;
                    }
                case TypesOfErrors.InputedNotANumberString:
                    {
                        Console.WriteLine("Введенная строка не является числом, попробуйте снова");
                        break;
                    }

                default:
                    break;
            }
        }

        public static void PrintIntroductoreText(IntroductoryText en)
        {
            switch (en)
            {
                case IntroductoryText.ModeChoosing:
                    {
                        Console.WriteLine("Выберите режим работы"+Environment.NewLine+"1. Режим наблюдения"+ Environment.NewLine+"2. Режим отката");
                        break;
                    }
                case IntroductoryText.PressEscapeForExit:
                    {
                        Console.WriteLine("Для выхода из режима наблюдения нажмите Escape");
                        break;
                    }
                case IntroductoryText.TheRollbackWasSuccessfull:
                    {
                        Console.WriteLine("Откат произошел успешно");
                        break;
                    }
                case IntroductoryText.ChooseFolderForRollback:
                    {
                        Console.WriteLine("Выберите дату из списка выше");
                        break;
                    }
            }
        }
    }
}
