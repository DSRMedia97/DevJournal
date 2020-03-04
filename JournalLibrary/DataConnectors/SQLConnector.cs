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

        public void CreateBookModel(BookModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();

                p.Add("@BookName", model.BookName);
                p.Add("@AuthorName", model.AuthorName);
                p.Add("@Price", model.Price);
                p.Add("@HasRead", model.Read);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("spBooks_Insert", p, commandType: CommandType.StoredProcedure);

                model.ID = p.Get<int>("@id");
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

        public List<CategoryModel> LoadAllCategories()
        {
            List<CategoryModel> output = new List<CategoryModel>();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<CategoryModel>("dbo.spCategories_GetAll").ToList();
            }

            return output;   
        }

        public void UpdateBookModel(BookModel model)
        {
            
        }
    }
}
