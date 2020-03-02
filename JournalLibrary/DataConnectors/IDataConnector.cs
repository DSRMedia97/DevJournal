using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JournalLibrary.Models;

namespace JournalLibrary.DataConnectors
{
    public interface IDataConnector
    {
        List<BookModel> LoadAllBooks();

        List<CategoryModel> LoadAllCategories();

        void UpdateBookModel(BookModel model);

        void CreateBookModel(BookModel model);

        void CreateCategoryModel(CategoryModel model);
    }
}
