using System.IO;

namespace Task_4
{
    public class FileInstruments
    {
        public static void CopyDirectory(string inputString, string outputString)
        {
            foreach (var file in new DirectoryInfo(inputString).GetFiles())
            {
                string fileNameInLogFolder = outputString + "\\" + file.Name;
                using (File.Create(fileNameInLogFolder)) ;
                File.Copy(file.FullName, fileNameInLogFolder, true);
            }
            foreach (var directory in new DirectoryInfo(inputString).GetDirectories())
            {
                string directoryNameInLogFolder = outputString + "\\" + directory.Name;
                Directory.CreateDirectory(directoryNameInLogFolder);
                CopyDirectory(directory.FullName, directoryNameInLogFolder);
            }
        }
        public static void ClearDirectory(DirectoryInfo dir)
        {
            dir.Delete(true);
            dir.Create();
        }
    }
}
