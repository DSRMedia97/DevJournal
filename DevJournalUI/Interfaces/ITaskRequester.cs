﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JournalLibrary.Models;

namespace DevJournalUI.Interfaces
{
    public interface ITaskRequester
    {
        void TaskComplete(TaskModel model);
    }
}
