using System;
using System.IO;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var researchedPath = @"D:\Simples\ResearchedFolder";
            var logPath = new DirectoryInfo(researchedPath).Parent.FullName + "\\HiddenFolder";
            CreateHiddenDirectory(logPath);
            PrintInfo.PrintIntroductoreText(IntroductoryText.ModeChoosing);
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    {
                        Watcher wtchr = new Watcher(researchedPath, logPath);
                        PrintInfo.PrintIntroductoreText(IntroductoryText.PressEscapeForExit);
                        while (Console.ReadKey().Key != ConsoleKey.Escape) ;
                        break;
                    }
                case 2:
                    {
                        RollBacker rl = new RollBacker(researchedPath, logPath);
                        PrintInfo.PrintListOfHiddenFolders(new DirectoryInfo(logPath).GetDirectories());
                        PrintInfo.PrintIntroductoreText(IntroductoryText.ChooseFolderForRollback);
                        while (!rl.SwitchVersion(Console.ReadLine())) ;
                        break;
                    }

                default:
                    break;
            }

            Console.ReadKey();


        }

        private static void CreateHiddenDirectory(string logPath)
        {
            if (!Directory.Exists(logPath))
            {
                DirectoryInfo di = Directory.CreateDirectory(logPath);
                di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            }
        }

        private static int GetIntFromReadline()
        {
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                PrintInfo.PrintErrorInConsole(TypesOfErrors.InputedNotANumberString);
            }
            return result;
        }
    }
}
