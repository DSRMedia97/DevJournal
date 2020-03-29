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

        List<OnlineCourseModel> LoadCoursesByCategory(int categoryID);

        List<CategoryModel> LoadCategoriesByBook(int bookID);

        List<CategoryModel> LoadCategoriesByOnlineCourse(int courseID);

        List<CategoryModel> LoadAllCategories();

        List<CategoryModel> LoadAllCategoriesFull();

        List<OnlineCourseModel> LoadAllOnlineCourses();

        void UpdateBookModel(BookModel model, List<CategoryModel> currentCategories);

        void CreateBookModel(BookModel model, List<CategoryModel> currentCategories);

        void CreateCategoryModel(CategoryModel model);

        void UpdateOnlineCourseModel(OnlineCourseModel model, List<CategoryModel> currentCategories);

        void CreateOnlineCourseModel(OnlineCourseModel model, List<CategoryModel> currentCategories);

        void CreateStudyTrainingModel(TrainingModel model);
    }
}
