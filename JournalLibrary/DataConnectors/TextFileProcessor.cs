using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;
using JournalLibrary.Models;

namespace JournalLibrary.DataConnectors.TextFileHelpers
{
    public static class TextFileProcessor
    {
        //Extension method that returns full file path of the file being queried
        public static string FullFilePath (this string fileName)
        {
            return $"{ ConfigurationManager.AppSettings["filePath"] }\\{ fileName }";
        }

        //Extension method that returns the contents of the file as a list of strings
        public static List<string> LoadFile (this string file)
        {
            //if the file doesn't already exist return new empty list of strings
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            //else return the file as a list
            return File.ReadAllLines(file).ToList();
        }



    }
}
