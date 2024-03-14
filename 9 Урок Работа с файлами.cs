using System;
using System.Collections.Generic;
using System.Collections;
using static System.Console;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        /*    DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                WriteLine($"Name: {drive.Name}");
                WriteLine($"Type: {drive.DriveType}");
                if (drive.IsReady)
                {
                    WriteLine($"Tom: {drive.VolumeLabel}");
                    WriteLine($"Obyom: {drive.TotalSize}");
                    WriteLine($"Empty: {drive.TotalFreeSpace}");
                    WriteLine($"Empty %: {(float)drive.TotalFreeSpace / drive.TotalSize * 100}");
                    WriteLine($"occupied: {drive.TotalSize - drive.TotalFreeSpace}");

                }
            }

            DriveInfo info = new DriveInfo("c");
            WriteLine($"Name: {info.Name}");
            WriteLine($"Type: {info.DriveType}");
            if (info.IsReady)
            {
                WriteLine($"Tom: {info.VolumeLabel}");
                WriteLine($"Obyom: {info.TotalSize}");
                WriteLine($"Empty: {info.TotalFreeSpace}");
                WriteLine($"Empty %: {(float)info.TotalFreeSpace / info.TotalSize * 100}");
                WriteLine($"occupied: {info.TotalSize - info.TotalFreeSpace}");

            }*/
        /*
                string dirName = "C:\\";

                if(Directory.Exists(dirName))
                {
                    WriteLine("Pokatalog: ");
                    string[] dir = Directory.GetDirectories(dirName);
                    foreach(string file in dir)
                    {
                        WriteLine(file);
                    }

                    WriteLine();
                    WriteLine("Pokatalog: ");
                    string[] files = Directory.GetFiles(dirName);
                    foreach (string file in files)
                    {
                        FileInfo fi = new FileInfo(file);
                        WriteLine(fi);
                        WriteLine(fi.Name);
                        WriteLine(fi.Length);
                        WriteLine(fi.LinkTarget);
                        WriteLine(fi.Attributes);
                        WriteLine(fi.Extension);
                    }
                }*/

        string path = @"C:\FileDesctop.txt";
        string text = "Hello World";
        try
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            byte[] buffer = Encoding.Default.GetBytes(text);
            fs.WriteAsync(buffer, 0, buffer.Length);
            WriteLine("Текст записан");
            fs.Close();
        }
        catch(FileNotFoundException fnf)
        {
            WriteLine(fnf.Message);
        }

        try
        {
            FileStream fs = File.OpenRead(path);
            byte[] buffer = new byte[fs.Length];
            fs.ReadAsync(buffer, 0, buffer.Length);
            string textFronFile = Encoding.Default.GetString(buffer);
            WriteLine($"Text {textFronFile}");
            fs.Close();
        }
        catch(FileNotFoundException fnf)
        {
            WriteLine(fnf.Message);
        }
    }
}