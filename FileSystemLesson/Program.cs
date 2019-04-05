using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace FileSystemLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //    string fullPath = string.Empty; //" " -одно и тоже
            //    List<DriveInfo> drives = DriveInfo.GetDrives().ToList();
            //    try
            //    {
            //        for (int i = 0; i < drives.Count; i++)
            //        {
            //            if (drives[i].IsReady)
            //                Console.WriteLine($"{i}.Имя:{drives[i].Name}\nПолный размер:{drives[i].TotalSize}\nСвободное место:{drives[i].TotalFreeSpace}");
            //        }
            //    }
            //    catch (IOException exception)
            //    {
            //        Console.WriteLine(exception.Message);
            //    }
            //    Console.WriteLine("Выберите порядковый номер диска:");
            //    int drivePosition = int.Parse(Console.ReadLine());

            //    fullPath += drives[drivePosition].Name;
            //    Console.Clear();

            //    DirectoryInfo directoryInfo = new DirectoryInfo(fullPath);
            //    FileSystemInfo[] systemFiles = directoryInfo.GetFileSystemInfos();

            //    for (int i = 0; i < systemFiles.Length; i++)
            //    {
            //        //string extension = string.IsNullOrEmpty(systemFiles[i].Extension) ? "---" : systemFiles[i].Extension;
            //        string extension = "---";
            //        if (!string.IsNullOrEmpty(systemFiles[i].Extension))
            //        {
            //            extension = systemFiles[i].Extension;
            //        }

            //        Console.WriteLine($"{i}. Имя:{systemFiles[i].Name}" + $"Расширение:{extension}");
            //    }
            //    Console.WriteLine("Выберите порядковый номер файла или папки:");
            //    int systemInfoPosition = int.Parse(Console.ReadLine());
            //    fullPath += systemFiles[systemInfoPosition].Name;

            //    if (!string.IsNullOrEmpty(systemFiles[systemInfoPosition].Extension))
            //    {
            //        Process.Start(fullPath);
            //    }
            //    else
            //    {
            //        //запустить снова обзор новой папки
            //    }
            //}
            //-----------------------------ДДДДДДДДДРРРРРРРРРРРРРРУУУУУУУУУУГГГГГГГГГГГГОООООООООООООЙЙЙЙЙЙЙЙЙЙЙЙ ПРОЕКТ
            //{
                //File.Create(@"C:\1\data.txt").Close();
                //using (StreamWriter writer = new StreamWriter(@"C:\1\data.txt"))
                //{
                //    string data = "Какой то текст";
                //    writer.WriteLine(data); //открылы вентиль чтобы пошел поток
                //}
                //using (StreamReader reader= new StreamReader(@"C:\1\data.txt"))
                //{
                //    string result = reader.ReadToEnd(); //открылы вентиль чтобы пошел поток
                //    Console.WriteLine(result);
                //}
                //--------------------------------------ДДДДДДДДДРРРРРРРРРРРРРРУУУУУУУУУУГГГГГГГГГГГГОООООООООООООЙЙЙЙЙЙЙЙЙЙЙЙ ПРОЕКТ

                using(var stream = new FileStream(@"C:\1\data.txt", FileMode.OpenOrCreate))
                {
                    string data = "123asd";
                    byte[] array = Encoding.UTF8.GetBytes(data);
                    stream.Write(array, 0, array.Length);
                }
            using (var stream = new FileStream(@"C:\1\data.txt", FileMode.OpenOrCreate))
            {
                byte[] array = new byte[stream.Length];
                stream.Read(array, 0, array.Length);
                string result = Encoding.UTF8.GetString(array);
            }
            // }
        }
    }
}
