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

        public List<BookModel> LoadBooksByCategory(int categoryID, bool unreadOnly)
        {
            //TODO - 
            return new List<BookModel>();
        }

        public List<CategoryModel> LoadCategoriesByBook(int bookID)
        {
            //TODO - 
            return new List<CategoryModel>();
        }

        public List<CategoryModel> LoadAllCategories()
        {
            return GlobalConfig.CategoriesFile.FullFilePath().LoadFile().ConvertToCategoryModels();
        }

        public void UpdateBookModel(BookModel model, List<CategoryModel> selectedCategories)
        {
            List<BookModel> books = GlobalConfig.BooksFile.FullFilePath().LoadFile().ConvertToBookModels();

            books[books.FindIndex(x => x.ID == model.ID)] = model;

            books.SaveToBookFile();
        }

        public void CreateBookModel(BookModel model, List<CategoryModel> selectedCategories)
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

        private void UpdateCategoryBookLinks(int categoryID, int bookID)
        {

        }

        public void CreateCategoryModel(CategoryModel model)
        {
            List<CategoryModel> categories = GlobalConfig.CategoriesFile.FullFilePath().LoadFile().ConvertToCategoryModels();

            int currentID = 1;

            if (categories.Count() > 0)
            {
                currentID = categories.OrderByDescending(x => x.ID).First().ID + 1;
            }

            model.ID = currentID;

            categories.Add(model);

            categories.SaveToCategoryFile();
        }
    }
}
