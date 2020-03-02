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
        #region Basic Extension Methods
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
        #endregion

        #region Convert Data From File Methods
        public static List<BookModel> ConvertToBookModels(this List<string> lines)
        {
            List<BookModel> output = new List<BookModel>();

            foreach(string line in lines)
            {
                string[] cols = line.Split(',');

                BookModel b = new BookModel();

                b.ID = int.Parse(cols[0]);
                b.BookName = cols[1];
                b.AuthorName = cols[2];
                b.Price = double.Parse(cols[3]);
                b.Read = bool.Parse(cols[4]);
                //b.Categories = cols[5];

                output.Add(b);
            }

            return output;
        }

        public static List<CategoryModel> ConvertToCategoryModels(this List<string> lines)
        {
            List<CategoryModel> output = new List<CategoryModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                CategoryModel c = new CategoryModel();

                c.ID = int.Parse(cols[0]);
                c.CategoryName = cols[1];

                output.Add(c);
            }

            return output;
        }
        #endregion

        #region Save to File Methods
        public static void SaveToBookFile(this List<BookModel> models)
        {
            List<string> lines = new List<string>();

            foreach (BookModel b in models)
            {
                string categoryIDs = "";

                foreach (CategoryModel c in b.Categories)
                {
                    categoryIDs += $"{ c.ID.ToString() }|";
                }
                if (categoryIDs.Length > 0)
                {
                    categoryIDs = categoryIDs.Substring(0, categoryIDs.Length - 1);
                }

                lines.Add($"{ b.ID },{ b.BookName },{ b.AuthorName },{ b.Price },{ b.Read },{ categoryIDs }");
            }

            File.WriteAllLines(GlobalConfig.BooksFile.FullFilePath(), lines);
        }

        public static void SaveToCategoryFile(this List<CategoryModel> models)
        {
            List<string> lines = new List<string>();

            foreach(CategoryModel c in models)
            {
                lines.Add($"{ c.ID },{ c.CategoryName }");
            }

            File.WriteAllLines(GlobalConfig.CategoriesFile.FullFilePath(), lines);
        }
        #endregion

    }
}
