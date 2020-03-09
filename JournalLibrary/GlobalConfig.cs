using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JournalLibrary.DataConnectors;
using System.Configuration;

namespace JournalLibrary
{
    public static class GlobalConfig
    {
        public const string BooksFile = "BookModels.csv";
        public const string CategoriesFile = "CategoryModels.csv";

        public static IDataConnector Connection { get; private set; }

        public static void InitializeConnections( DatabaseType db )
        {
            if (db == DatabaseType.Sql)
            {
                SQLConnector sql = new SQLConnector();
                Connection = sql;
            }
            //else if (db == DatabaseType.TextFile)
            //{
            //    TextFileConnector text = new TextFileConnector();
            //    Connection = text;
            //}
            else
            {
                throw new NullReferenceException("Data source not defined.");
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
