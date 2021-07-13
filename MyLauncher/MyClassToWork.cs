using System;
using System.IO;
using System.Security.Cryptography;
using System.Diagnostics;

namespace MyLauncher
{
    class MyClassToWork
    {
        string pathOrigin;
        string pathDestination;

        public delegate void EventProgressBar(int tickCount);
        public event EventProgressBar ProgressBarTick;

        public delegate void EventTextBoxMessage(string action);
        public event EventTextBoxMessage MessageInTextBox;

        public delegate void EventErrorMEssage(string action);
        public event EventErrorMEssage MessageInforming;

        public delegate void EventSuccessEnd();
        public event EventSuccessEnd ShowEnd;

        public MyClassToWork(string pathOrigin, string pathDestination)
        {
            this.pathOrigin = @pathOrigin;
            this.pathDestination = @pathDestination;
        }


        public int CalculateFileCount()
        {
            if (pathOrigin != "")
                if (pathDestination != "")
                {
                    DirectoryInfo folderOrigin = new DirectoryInfo(pathOrigin.Substring(0, pathOrigin.LastIndexOf('\\')));
                    DirectoryInfo folderDestination = new DirectoryInfo(pathDestination);
                    return GetFiles(folderOrigin) + GetFiles(folderDestination);
                }
            return 1;
        }

        public int GetFiles(DirectoryInfo path)
        {
            int count = 0;
            FileInfo[] current_dir = path.GetFiles();
            count += current_dir.Length;

            DirectoryInfo[] dirs = path.GetDirectories();
            foreach (DirectoryInfo elem in dirs)
            {
                count += GetFiles(elem);
            }
            return count;
        }

        public void ExecuteInstallation()
        {
            if (pathOrigin == "")
                MessageInforming?.Invoke("Не выбран файл для установки");
            else
            if (pathDestination == "")
                MessageInforming?.Invoke("Не выбран путь для установки");
            else
            if (!CheckFreeFolder())
                MessageInforming?.Invoke("Необходимо выбрать пустую папку для установки");
            else
            {
                MessageInTextBox?.Invoke("Instalation start\n");
                Installation(pathOrigin);
                ShowEnd?.Invoke();
                MessageInforming?.Invoke("Installation successfully ended");
                Process.Start(Path.Combine(pathDestination, pathOrigin.Substring(pathOrigin.LastIndexOf('\\')+1)));
                Environment.Exit(0);
            }
        }

        public void Installation(string path)
        {
            string stringFolder = path.Substring(0, path.LastIndexOf('\\'));
            DirectoryInfo folder = new DirectoryInfo(stringFolder);
            string currentDirectory = "";
            if (path.Length != pathOrigin.Length)
                currentDirectory = stringFolder.Substring(pathOrigin.LastIndexOf('\\')+1);

            FileInfo[] current_dir = folder.GetFiles();
            foreach (FileInfo elem in current_dir)
            {
                MessageInTextBox?.Invoke("Instal file(Start) - " + elem.Name + '\n');
                File.Copy(elem.FullName, Path.Combine(pathDestination, currentDirectory, elem.Name));
                ProgressBarTick?.Invoke(1);
                MessageInTextBox?.Invoke("Instal file(Done)  - " + elem.Name + '\n');
            }

            DirectoryInfo[] dirs = folder.GetDirectories();
            foreach (DirectoryInfo elem in dirs)
            {
                Directory.CreateDirectory(Path.Combine(pathDestination, currentDirectory, elem.Name));
                MessageInTextBox?.Invoke("Create directiory(Done) - " + elem.Name + '\n');
                Installation(elem.FullName.ToString() + '\\');
            }
        }

        public bool CheckFreeFolder()
        {
            DirectoryInfo folderDestination = new DirectoryInfo(pathDestination);
            FileInfo[] current_dir = folderDestination.GetFiles();
            DirectoryInfo[] dirs = folderDestination.GetDirectories();

            if (dirs.Length > 0 || current_dir.Length > 0)
                return false;
            return true;
        }


        public void ExecuteUpdate()
        {
            if (pathOrigin == "")
                MessageInforming?.Invoke("Не выбран файл для обновления");
            else
            if (pathDestination == "")
                MessageInforming?.Invoke("Не выбран путь для обновления");
            else
            if (!CheckInstaledData())
                MessageInforming?.Invoke("Выбранная папка не содержит экземпляра программы");
            {
                MessageInTextBox?.Invoke("Update start\n");
                Update(pathOrigin);
                ShowEnd?.Invoke();
                MessageInforming?.Invoke("Update successfully ended");
                Process.Start(Path.Combine(pathDestination, pathOrigin.Substring(pathOrigin.LastIndexOf('\\')+1)));
                Environment.Exit(0);
            }
        }

        public void Update(string path)
        {
            string stringFolderOrigin = path.Substring(0, path.LastIndexOf('\\'));
            DirectoryInfo folderOrigin = new DirectoryInfo(stringFolderOrigin);
            string currentDirectory = "";
            if (path.Length != pathOrigin.Length)
                currentDirectory = stringFolderOrigin.Substring(pathOrigin.LastIndexOf('\\') + 1);

            DirectoryInfo destinationFolder = new DirectoryInfo(Path.Combine(pathDestination, currentDirectory));
            FileInfo[] destination_current_dir = destinationFolder.GetFiles();
            foreach (FileInfo elem in destination_current_dir)
            {
                if (!File.Exists(Path.Combine(stringFolderOrigin, elem.Name)))
                {
                    File.Delete(elem.FullName);
                    MessageInTextBox?.Invoke("Delete old file(Done) - " + elem.Name + '\n');
                    ProgressBarTick?.Invoke(1);
                }                
            }
            DirectoryInfo[] destinationDirs = destinationFolder.GetDirectories();
            foreach (DirectoryInfo elem in destinationDirs)
            {
                if (!Directory.Exists(Path.Combine(stringFolderOrigin, elem.Name)))
                {
                    Directory.Delete(elem.FullName, true);
                    MessageInTextBox?.Invoke("Delete old directory(Done) - " + elem.Name + '\n');
                }
            }

            FileInfo[] current_dir = folderOrigin.GetFiles();
            foreach (FileInfo elem in current_dir)
            {
                string s1 = HashSum(elem.FullName);
                string s2 = HashSum(Path.Combine(pathDestination, currentDirectory, elem.Name));

                if (HashSum(elem.FullName).Equals(HashSum(Path.Combine(pathDestination, currentDirectory, elem.Name))))
                {
                    ProgressBarTick?.Invoke(2);
                    MessageInTextBox?.Invoke("No need to update file - " + elem.Name + '\n');
                }
                else
                {
                    if (File.Exists(Path.Combine(pathDestination, currentDirectory, elem.Name)))
                    {
                        File.Delete(Path.Combine(pathDestination, currentDirectory, elem.Name));
                        ProgressBarTick?.Invoke(1);
                        MessageInTextBox?.Invoke("Delete old file(Done) - " + elem.Name + '\n');
                    }
                    MessageInTextBox?.Invoke("Instal file(Start) - " + elem.Name + '\n');
                    File.Copy(elem.FullName, Path.Combine(pathDestination, currentDirectory, elem.Name));
                    ProgressBarTick?.Invoke(1);
                    MessageInTextBox?.Invoke("Instal file(Done)  - " + elem.Name + '\n');
                }
            }

            DirectoryInfo[] dirs = folderOrigin.GetDirectories();
            foreach (DirectoryInfo elem in dirs)
            {
                if (!Directory.Exists(Path.Combine(pathDestination, currentDirectory, elem.Name)))
                {
                    Directory.CreateDirectory(Path.Combine(pathDestination, currentDirectory, elem.Name));
                    MessageInTextBox?.Invoke("Create directiory(Done) - " + elem.Name + '\n');
                }
                Update(elem.FullName.ToString() + '\\');
            }
        }
        public string HashSum(string path)
        {
            if (!File.Exists(path))
                return "null";
            using (FileStream fs = System.IO.File.OpenRead(path))
            {
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] fileData = new byte[fs.Length];
                fs.Read(fileData, 0, (int)fs.Length);
                byte[] checkSum = md5.ComputeHash(fileData);
                return BitConverter.ToString(checkSum).Replace("-", String.Empty);
            }
        }
        public bool CheckInstaledData()
        {
            FileInfo file = new FileInfo(pathOrigin);
            if (File.Exists(Path.Combine(pathDestination, file.Name)))
                return true;
            return false;
        }

    }
}
