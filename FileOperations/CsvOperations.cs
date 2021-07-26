﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;
using CsvHelper;

namespace FileOperations
{
    public class CsvOperations
    {
        //public static string importFilePath = @"C:\Users\ven\source\repos\FileOperations\FileOperations\csvdata.csv";
        //Read Content of CSV File and Print
        public static void CsvDeSerailize()
        {
            //Initialization
            string importFilePath = @"C:\Users\ven\source\repos\FileOperations\FileOperations\csvdata.csv";
            using var reader = new StreamReader(importFilePath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var result = csv.GetRecords<Person>().ToList();
            foreach (Person m in result)
            {
                Console.WriteLine("Name: {0} \t Email: {1} \t Phone Number: {2} \t Country: {3}", m.name, m.email, m.phoneNum, m.country);
            }
        }

        public static void CsvSerailize()
        {
            string exportfile = @"C:\Users\Radhika\source\repos\FileIOOperations\FileIOOperations\csvdata.csv";
            using var writer = new StreamWriter(exportfile);

            using var csvWrite = new CsvWriter(writer, CultureInfo.InvariantCulture);

            List<Person> data = new List<Person>
            {
            new Person("Gayatri","gaya@yahoo.com",9894527257,"India") };
            csvWrite.WriteRecords(data);
            csvWrite.NextRecord();
            CsvDeSerailize();
        }
    }
}
