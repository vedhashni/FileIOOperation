using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileOperations
{
    /// <summary>
    /// Checking File exists or not
    /// Read All lines in the File
    /// Read All Text in File
    /// Copy a file
    /// Delete A file
    /// </summary>
    public class FileIOOperations
    {
        public static bool FileExists(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    Console.WriteLine("File exists");
                    return true;
                }
                else
                {
                    Console.WriteLine("File not exists");
                    return false;
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static void ReadAllLinesInFile()
        {
            try
            {
                string[] lines;
                string path = @"C:\Users\ven\source\repos\FileOperations\FileOperations\TextFile.txt";
                FileExists(path);
                lines = File.ReadAllLines(path);
                if (lines.Length != 0)
                {
                    foreach (var i in lines)
                    {
                        Console.WriteLine(i + " ");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void ReadAllTextInFile()
        {
            try
            {
                string text;
                string path = @"C:\Users\ven\source\repos\FileOperations\FileOperations\TextFile.txt";
                FileExists(path);
                text = File.ReadAllText(path);
                if (text.Length != 0)
                {
                    Console.WriteLine(text);
                }
                else
                {
                    Console.WriteLine("File does not contain text");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void CopyFile()
        {
            string sourcePath = @"C:\Users\ven\source\repos\FileOperations\FileOperations\TextFile.txt";
            string destPath = @"C:\Users\ven\source\repos\FileOperations\FileOperations\TextFile1.txt";
            try
            {
                File.Copy(sourcePath, destPath, true);
                Console.WriteLine("file is copied successfully");
            }
            catch (IOException iox)
            {
                Console.WriteLine(iox.Message);
            }
        }

        public static void DeleteFile()
        {
            try
            {
                string delFile = @"C:\Users\ven\source\repos\FileOperations\FileOperations\TextFile1.txt";
                if (FileExists(delFile))
                {
                    File.Delete(delFile);
                    Console.WriteLine("File deleted");
                }
                else
                {
                    Console.WriteLine("File not found!!!");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
