using System;
using System.Collections.Generic;
using System.IO;

namespace NameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "/Users/jordanswalker/Documents/99ConsoleApplications/99ConsoleApplications/Applications/NameGenerator/len-us-first-names-database/babynames-clean.csv";
            using (var reader = new StreamReader(@filePath))
            {
                Dictionary<string, string> nameGender = new Dictionary<string, string>();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    nameGender.Add(values[0], values[1]);
                }

                foreach (var item in nameGender)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
