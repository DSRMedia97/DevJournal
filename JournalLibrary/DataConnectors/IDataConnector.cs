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

        List<BookModel> LoadBooksByCategory(int categoryID, bool unreadOnly);

        List<CategoryModel> LoadCategoriesByBook(int bookID);

        List<CategoryModel> LoadAllCategories();

        void UpdateBookModel(BookModel model, List<CategoryModel> currentCategories);

        void CreateBookModel(BookModel model, List<CategoryModel> currentCategories);

        void CreateCategoryModel(CategoryModel model);
    }
}
