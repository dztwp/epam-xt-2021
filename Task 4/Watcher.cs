using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_4
{
    public enum EventTypes
    {
        OnRename,
        OnChange,
        OnCreate,
        OnDelete
    }

    class Watcher
    {
        FileSystemWatcher _watcher;
        DirectoryInfo _logDirectory;
        DirectoryInfo _researchDirectory;
        public Watcher(string pathOfResearchingFolder, string pathToLogFolder)
        {
            _watcher = new FileSystemWatcher(pathOfResearchingFolder);
            _logDirectory = new DirectoryInfo(pathToLogFolder);
            _researchDirectory = new DirectoryInfo(pathOfResearchingFolder);
            InitializeFileSystemWatcher();

        }

        private void InitializeFileSystemWatcher()
        {
            _watcher.NotifyFilter = NotifyFilters.Attributes
                                             | NotifyFilters.CreationTime
                                             | NotifyFilters.DirectoryName
                                             | NotifyFilters.FileName
                                             | NotifyFilters.LastAccess
                                             | NotifyFilters.LastWrite
                                             | NotifyFilters.Security
                                             | NotifyFilters.Size;
            _watcher.Filter = "*.txt";
            _watcher.Changed += OnChanged;
            _watcher.Created += OnCreated;
            _watcher.Deleted += OnDeleted;
            _watcher.Renamed += OnRenamed;
            _watcher.Error += OnError;
            _watcher.IncludeSubdirectories = true;
            _watcher.EnableRaisingEvents = true;
        }

        private void OnError(object sender, ErrorEventArgs e)
        {
            PrintInfo.PrintException(e.GetException());
        }

        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            PrintInfo.PrintInfoAboutEvents(EventTypes.OnRename, e.Name, e.OldName);
            CreateBackup(e);

        }

        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            PrintInfo.PrintInfoAboutEvents(EventTypes.OnDelete, e.Name);
            CreateBackup(e);
        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            PrintInfo.PrintInfoAboutEvents(EventTypes.OnCreate, e.Name);
            CreateBackup(e);
        }
        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            PrintInfo.PrintInfoAboutEvents(EventTypes.OnChange, e.Name);
            Console.WriteLine(e.Name);
            CreateBackup(e);
        }

        private void CreateBackup(FileSystemEventArgs e)
        {
            string backupFolderName = $"{DateTime.Now.Year}.{DateTime.Now.Month}.{DateTime.Now.Day} - {DateTime.Now.Hour}.{DateTime.Now.Minute}.{DateTime.Now.Second}";
            _logDirectory.CreateSubdirectory(backupFolderName);
            string pathToHiddenBackupFolder = _logDirectory.FullName + '\\' + backupFolderName;
            FileInstruments.CopyDirectory(_researchDirectory.FullName, pathToHiddenBackupFolder);
        }
      

    }
}
