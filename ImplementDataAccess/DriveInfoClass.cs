using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ImplementDataAccess
{
    public class DriveInfoClass
    {
        public void GetDriveInfoDetails()
        {
            DriveInfo[] drivesInfo = DriveInfo.GetDrives();

            foreach (DriveInfo driveInfo in drivesInfo)
            {
                Console.WriteLine("Drive Info: ", driveInfo.Name);
                Console.WriteLine("File Type: ", driveInfo.DriveType);

                if (driveInfo.IsReady == true)
                {
                    Console.WriteLine("Total Free Size: " + driveInfo.TotalFreeSpace);
                    Console.WriteLine("Total Size: " +driveInfo.TotalSize);
                    Console.WriteLine("Volumn Label: " +driveInfo.VolumeLabel);
                    Console.WriteLine("Root Directory: " +driveInfo.RootDirectory);
                    Console.WriteLine("Drive Format: " +driveInfo.DriveFormat);
                }
                Console.WriteLine("--------------------------------");
            }

            var directory = Directory.CreateDirectory(@"D:\TestFolderName");
            var directoryInfo = new DirectoryInfo(@"D:\TestFolderNameDI");
            directoryInfo.Create();

            if (Directory.Exists(@"D:\TestFolderNameDI"))
            {
                Directory.Delete(@"D:\TestFolderNameDI");
            }

            directoryInfo = new DirectoryInfo(@"D:\TestFolder");
            if (directoryInfo.Exists)
            {
                directoryInfo.Delete();
            }

            DirectoryInfo dirInfo = new DirectoryInfo(@"D:\TestDirectory");
            directoryInfo.Create();
            try
            {
                DirectorySecurity dirSecurity = dirInfo.GetAccessControl();

                dirSecurity.AddAccessRule(new FileSystemAccessRule("everyone",
                FileSystemRights.ReadAndExecute,
                AccessControlType.Allow));

                dirInfo.SetAccessControl(dirSecurity);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Exception occured: ", ex.Message);
            }
        }

        public static void ListDirectories(DirectoryInfo dirInfo, string searchPattern, int maxLevel, int currentLevel)
        {
            if (currentLevel >= maxLevel)
            {
                return;
            }

            string indent = new string('-', currentLevel);

            try {

                DirectoryInfo[] subDirectories = dirInfo.GetDirectories(searchPattern);
                foreach (DirectoryInfo di in subDirectories)
                {
                    Console.WriteLine(indent + di.Name);
                    ListDirectories(di, searchPattern, maxLevel, currentLevel + 1);
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine(indent + "Don't have access" + dirInfo.Name);
                return;
            }
        }

        public static void DirectoryMove(string sourceDirName, string destDirName)
        {
            try
            {
                Directory.Move(sourceDirName, destDirName);
            }
            catch (DirectoryNotFoundException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        public static void GetDirectoryUsingFile()
        {
            try
            {
                Console.WriteLine("Using Directory Class:");
                foreach (string file in Directory.GetFiles(@"D:\Test"))
                {
                    Console.WriteLine(file);
                }

                Console.WriteLine("Using DirectoryInfo class:");
                DirectoryInfo dirInfo = new DirectoryInfo(@"D:\Test");
                foreach (FileInfo fi in dirInfo.GetFiles())
                {
                    Console.WriteLine(fi.FullName);
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }

        public static void DeleteFile()
        {
            string path = @"D:\Test\Hello - Copy.txt";

            //if (File.Exists(path))
            //{
            //    File.Delete(path);
            //}

            FileInfo fileInfo = new FileInfo(path);

                if (fileInfo.Exists)
            {
                fileInfo.Delete();
            }
        }

        public static void CopyFiles()
        {
            string path = @"D:\Test\Hello.txt";
            string destPath = @"D:\Test\DestTest1.txt";

            File.CreateText(path).Close();
            File.Copy(path, destPath);

            FileInfo file = new FileInfo(path);
            file.CopyTo(destPath);
        }

        public static void GetPathDetails()
        {
            string path = @"D:\Test\Hello.txt";

            Console.WriteLine(Path.GetDirectoryName(path));
            Console.WriteLine(Path.GetFileName(path));
            Console.WriteLine(Path.GetExtension(path));
            Console.WriteLine(Path.GetFullPath(path));
            Console.WriteLine(Path.GetPathRoot(path));
        }

        public static void FileCreateTextDemo()
        {
            string path = @"D:\Test\Hello2.txt";

            using (StreamWriter sw = File.CreateText(path))
            {
                string value = "Hello, this is create text file demo.";
                sw.Write(value);
            }
        }

        public static void WebRequestDemo()
        {
            try
            {
                WebRequest request = WebRequest.Create("http://www.microsoft.com");
                WebResponse response = request.GetResponse();

                StreamReader reader = new StreamReader(response.GetResponseStream());
                string responseText = reader.ReadToEnd();

                Console.WriteLine(responseText);
                response.Close();
            }
            catch (UriFormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static async Task CreateandWriteAsyncToFile()
        {
            using (FileStream fs = new FileStream(@"D:\Test\Hello.txt", FileMode.Create, FileAccess.Write, FileShare.None, 4096, true))
            {
                byte[] data = new byte[10000000];
                new Random().NextBytes(data);
                await fs.WriteAsync(data, 0, data.Length);
            }
        }
    }
}
