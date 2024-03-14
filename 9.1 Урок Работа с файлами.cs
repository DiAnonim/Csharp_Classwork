using System;
using System.IO;
using System.Text;
using static System.Console;
//C:\a.txt

class Program
{
    static void Main()
    {
        WriteLine("Enter Path: ");
        string path = ReadLine(); 
        FileStream sr = null;
        if (!File.Exists(path))
        {
            bool isUserRes = false;
            while (!isUserRes)
            {
                WriteLine("File not find. Create file? [Y/N]");
                string userRes = ReadLine(); switch (userRes)
                {
                    case "Y":
                        WriteLine("create is file");
                        sr = new FileStream(path, FileMode.CreateNew); 
                        isUserRes = true;
                        break;
                    case "N":
                        WriteLine("Not create is file"); 
                        isUserRes = true;
                        break;
                }
            }
        }
        else
        {
            sr = new FileStream(path, FileMode.Open);
        }
        if (sr != null)
        {
            byte[] buffer = new byte[sr.Length];
            sr.ReadAsync(buffer, 0, buffer.Length);
            string fileLine = Encoding.Default.GetString(buffer); WriteLine($"In file date: {path}");
            WriteLine(fileLine);
            WriteLine(); 
            WriteLine("Want to change the content? [Y/N]");
            string userRes = ReadLine(); switch (userRes)
            {
                case "Y":
                    WriteLine("Enter: "); 
                    string userContent = ReadLine();
                    byte[] userContentBuffer = Encoding.Default.GetBytes(userContent); 
                    sr.WriteAsync(userContentBuffer, 0, userContentBuffer.Length);
                    WriteLine("File changed"); break;
                case "N": break;
            }
            sr.Close();
        }
    }
}
