using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JournalLibrary.Models;
using JournalLibrary.DataConnectors.TextFileHelpers;

namespace JournalLibrary.DataConnectors
{
    class TextFileConnector : IDataConnector
    {
        public List<BookModel> LoadAllBooks()
        {
            return GlobalConfig.BooksFile.FullFilePath().LoadFile().ConvertToBookModels();
        }

        public void UpdateBookModel(BookModel model)
        {
            List<BookModel> books = GlobalConfig.BooksFile.FullFilePath().LoadFile().ConvertToBookModels();

            books[books.FindIndex(x => x.ID == model.ID)] = model;

            books.SaveToBookFile();
        }

        public void CreateBookModel(BookModel model)
        {
            List<BookModel> books = GlobalConfig.BooksFile.FullFilePath().LoadFile().ConvertToBookModels();

            int currentID = 1;

            if (books.Count() > 0)
            {
                currentID = books.OrderByDescending(x => x.ID).First().ID + 1;
            }

            model.ID = currentID;

            books.Add(model);

            books.SaveToBookFile();
        }
    }
}
