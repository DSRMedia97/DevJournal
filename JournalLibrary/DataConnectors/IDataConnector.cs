using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JournalLibrary.Models;

namespace JournalLibrary.DataConnectors
{
    public interface IDataConnector
    {
        void CreateBookModel(BookModel model);
    }
}
