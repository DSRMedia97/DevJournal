using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JournalLibrary.Models;

namespace JournalLibrary.DataConnectors
{
    class SQLConnector : IDataConnector
    {
        public void CreateBookModel(BookModel model)
        {
            throw new NotImplementedException();
        }

        public void CreateCategoryModel(CategoryModel model)
        {
            throw new NotImplementedException();
        }

        public List<BookModel> LoadAllBooks()
        {
            throw new NotImplementedException();
        }

        public List<CategoryModel> LoadAllCategories()
        {
            throw new NotImplementedException();
        }

        public void UpdateBookModel(BookModel model)
        {
            throw new NotImplementedException();
        }
    }
}
