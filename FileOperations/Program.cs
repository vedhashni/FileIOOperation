using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;

namespace FileOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FileIOOPerations");
            string path = @"C:\Users\ven\source\repos\FileOperations\FileOperations\TextFile.txt";

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    FileIOOperations.FileExists(path);
                    break;

                case 2:
                    FileIOOperations.ReadAllLinesInFile();
                    break;

                case 3:
                    FileIOOperations.ReadAllTextInFile();
                    break;

                case 4:
                    FileIOOperations.CopyFile();
                    break;

                case 5:
                    FileIOOperations.DeleteFile();
                    break;

                case 6:
                    FileIOOperations.ReadFromStreamReader();
                    break;

                case 7:
                    FileIOOperations.WriteUsingStreamWriter();
                    break;

                case 8:

                    CsvOperations.CsvSerailize();

                    break;
                case 9:
                    JsonOperations.ReadJsonAndWriteToCSV();
                    break;

                default:
                    break;

            }

        }
    }
}
