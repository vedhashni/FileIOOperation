using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FileIOOPerations");
            string path = @"C:\Users\ven\source\repos\FileOperations\FileOperations\TextFile.txt";
            FileIOOperations.FileExists(path);
        }
    }
}
