﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevJournalUI.ViewElementForms;
using DevJournalUI.EditElementForms;

namespace DevJournalUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //initialize data connections
            JournalLibrary.GlobalConfig.InitializeConnections(JournalLibrary.DatabaseType.Sql);

            Application.Run(new DevOverviewForm());
        }
    }
}
