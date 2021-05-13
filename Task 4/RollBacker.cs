using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_4
{
    class RollBacker
    {
        DirectoryInfo _logFolder, _researcedFolder;
        public RollBacker(string pathOfResearchingFolder, string pathToLogFolder)
        {
            _logFolder = new DirectoryInfo(pathToLogFolder);
            _researcedFolder = new DirectoryInfo(pathOfResearchingFolder);
        }

        public bool SwitchVersion(string inputedData)
        {
            if (_logFolder.GetDirectories().Any(x => x.Name == inputedData))
            {
                FileInstruments.ClearDirectory(_researcedFolder);
                FileInstruments.CopyDirectory(_logFolder.GetDirectories().Where(x => x.Name == inputedData).First().ToString(), _researcedFolder.FullName) ;
                PrintInfo.PrintIntroductoreText(IntroductoryText.TheRollbackWasSuccessfull);
                return true;
            }
            else
            {
                PrintInfo.PrintErrorInConsole(TypesOfErrors.InputedWrongFolderName);
                return false;
            }

        }
    }
}