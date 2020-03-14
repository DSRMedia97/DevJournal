using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JournalLibrary.Models;
using System.Data;
using Dapper;

namespace JournalLibrary.DataConnectors
{
    class SQLConnector : IDataConnector
    {
        private const string db = "DevJournal";

        public void CreateBookModel(BookModel model, List<CategoryModel> currentCategories)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();

                p.Add("@BookName", model.Title);
                p.Add("@AuthorName", model.AuthorName);
                p.Add("@Price", model.Price);
                p.Add("@HasRead", model.Read);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("spBooks_Insert", p, commandType: CommandType.StoredProcedure);

                model.ID = p.Get<int>("@id");

                foreach (CategoryModel cm in currentCategories)
                {
                    p = new DynamicParameters();

                    p.Add("@Bookid", model.ID);
                    p.Add("@Categoryid", cm.ID);

                    connection.Execute("spBookCategories_Insert", p, commandType: CommandType.StoredProcedure);
                }
            }
        }

        public void CreateCategoryModel(CategoryModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();

                p.Add("@Category", model.CategoryName);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spCategories_Insert", p, commandType: CommandType.StoredProcedure);

                model.ID = p.Get<int>("@id");
            }
        }

        public List<BookModel> LoadAllBooks()
        {
            List<BookModel> output = new List<BookModel>();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<BookModel>("dbo.spBooks_GetAll").ToList();
            }

            return output;
        }

        public List<BookModel> LoadBooksByCategory(int categoryID, bool unreadOnly)
        {
            List<BookModel> output = new List<BookModel>();

            var p = new DynamicParameters();

            p.Add("@Categoryid", categoryID);

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                if (unreadOnly)
                {
                    output = connection.Query<BookModel>("dbo.spBooks_GetUnreadByCategory", p, commandType: CommandType.StoredProcedure).ToList();
                }
                else
                {
                    output = connection.Query<BookModel>("dbo.spBooks_GetByCategory", p, commandType: CommandType.StoredProcedure).ToList();
                }
            }

            return output;
        }

        public List<CategoryModel> LoadCategoriesByBook(int bookID)
        {
            List<CategoryModel> output = new List<CategoryModel>();

            var p = new DynamicParameters();

            p.Add("@Bookid", bookID);

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<CategoryModel>("dbo.spCategories_GetByBook", p, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        public List<CategoryModel> LoadAllCategories()
        {
            List<CategoryModel> output = new List<CategoryModel>();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<CategoryModel>("dbo.spCategories_GetAll").ToList();
            }

            return output;   
        }

        public void UpdateBookModel(BookModel model, List<CategoryModel> currentCategories)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();

                p.Add("@BookName", model.Title);
                p.Add("@AuthorName", model.AuthorName);
                p.Add("@Price", model.Price);
                p.Add("@HasRead", model.Read);
                p.Add("@id", model.ID);

                //call sp to update book model -- similar to CreateBook but without the output id
                connection.Execute("dbo.spBooks_Update", p, commandType: CommandType.StoredProcedure);

                //call sp to get list of stored Categories for the book
                List<CategoryModel> storedCategories = new List<CategoryModel>();
                p = new DynamicParameters();
                p.Add("@Bookid", model.ID);
                storedCategories = connection.Query<CategoryModel>("spBookCategories_GetByBook", p, commandType: CommandType.StoredProcedure).ToList();

                //currentCategories list and storedCategories are both null then do nothing - nothing to update
                if (currentCategories != null && storedCategories != null)
                {
                    //do checks
                    foreach (CategoryModel c in currentCategories)
                    {
                        //if it already exists in the database remove it from further actions
                        if (storedCategories.Exists(x => x.ID == c.ID))
                        {
                            storedCategories.RemoveAt(storedCategories.FindIndex(x => x.ID == c.ID));
                        }
                        else //it doesn't already exist in the database so add it
                        {
                            p = new DynamicParameters();
                            p.Add("@Bookid", model.ID);
                            p.Add("@Categoryid", c.ID);
                            connection.Execute("spBookCategories_Insert", p, commandType: CommandType.StoredProcedure);
                        }
                    }
                    //if there are still categories that were on the database, but aren't in your list, remove them from database
                    if (storedCategories.Count > 0)
                    {
                        foreach (CategoryModel storedC in storedCategories)
                        {
                            p = new DynamicParameters();
                            p.Add("@Bookid", model.ID);
                            p.Add("@Categoryid", storedC.ID);
                            connection.Execute("spBookCategories_Remove", p, commandType: CommandType.StoredProcedure);
                        }
                    }
                }
                else if (currentCategories == null && storedCategories != null)
                {
                    //remove all from db in stored categories since nothing is assigned to the model categories
                    foreach (CategoryModel c in storedCategories)
                    {
                        p = new DynamicParameters();
                        p.Add("@Bookid", model.ID);
                        p.Add("@Categoryid", c.ID);
                        connection.Execute("spBookCategories_Remove", p, commandType: CommandType.StoredProcedure);
                    }
                }
                else if (currentCategories != null && storedCategories == null)
                {
                    //add all from model.categories to db since nothing was previously saved in db
                    foreach (CategoryModel c in currentCategories)
                    {
                        p = new DynamicParameters();
                        p.Add("@Bookid", model.ID);
                        p.Add("@Categoryid", c.ID);
                        connection.Execute("spBookCategories_Insert", p, commandType: CommandType.StoredProcedure);
                    }
                }
            }
        }
    }
}
