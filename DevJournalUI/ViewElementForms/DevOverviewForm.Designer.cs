﻿namespace DevJournalUI.ViewElementForms
{
    partial class DevOverviewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripHeader = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryToolStripHeader = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBooksToolStripLibraryItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOnlineCoursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryListBox = new System.Windows.Forms.ListBox();
            this.AddCategoryButton = new System.Windows.Forms.Button();
            this.CategoryDataTabs = new System.Windows.Forms.TabControl();
            this.OverviewTab = new System.Windows.Forms.TabPage();
            this.CategoryChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CategoryDetailsTab = new System.Windows.Forms.TabPage();
            this.CategoryDetailGroupBox = new System.Windows.Forms.GroupBox();
            this.SessionDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.RecentActivityGroupBox = new System.Windows.Forms.GroupBox();
            this.RecentActivityListBox = new System.Windows.Forms.ListBox();
            this.AddPracticeTimeSession = new System.Windows.Forms.Button();
            this.AddStudyTimeButton = new System.Windows.Forms.Button();
            this.TotalsGroupBox = new System.Windows.Forms.GroupBox();
            this.StudyTimeTotalValue = new System.Windows.Forms.Label();
            this.PracticeTimeTotalValue = new System.Windows.Forms.Label();
            this.PracticeTimeTotalLabel = new System.Windows.Forms.Label();
            this.StudyTimeTotalLabel = new System.Windows.Forms.Label();
            this.trainingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.CategoryDataTabs.SuspendLayout();
            this.OverviewTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryChart)).BeginInit();
            this.CategoryDetailsTab.SuspendLayout();
            this.CategoryDetailGroupBox.SuspendLayout();
            this.RecentActivityGroupBox.SuspendLayout();
            this.TotalsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripHeader,
            this.libraryToolStripHeader});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripHeader
            // 
            this.menuToolStripHeader.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuToolStripHeader.Name = "menuToolStripHeader";
            this.menuToolStripHeader.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripHeader.Text = "Menu";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuExitOption_Click);
            // 
            // libraryToolStripHeader
            // 
            this.libraryToolStripHeader.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewBooksToolStripLibraryItem,
            this.viewOnlineCoursesToolStripMenuItem});
            this.libraryToolStripHeader.Name = "libraryToolStripHeader";
            this.libraryToolStripHeader.Size = new System.Drawing.Size(55, 20);
            this.libraryToolStripHeader.Text = "Library";
            // 
            // viewBooksToolStripLibraryItem
            // 
            this.viewBooksToolStripLibraryItem.Name = "viewBooksToolStripLibraryItem";
            this.viewBooksToolStripLibraryItem.Size = new System.Drawing.Size(182, 22);
            this.viewBooksToolStripLibraryItem.Text = "View Books";
            this.viewBooksToolStripLibraryItem.Click += new System.EventHandler(this.viewBooksToolStripLibraryItem_Click);
            // 
            // viewOnlineCoursesToolStripMenuItem
            // 
            this.viewOnlineCoursesToolStripMenuItem.Name = "viewOnlineCoursesToolStripMenuItem";
            this.viewOnlineCoursesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.viewOnlineCoursesToolStripMenuItem.Text = "View Online Courses";
            this.viewOnlineCoursesToolStripMenuItem.Click += new System.EventHandler(this.viewOnlineCoursesToolStripMenuItem_Click);
            // 
            // CategoryListBox
            // 
            this.CategoryListBox.FormattingEnabled = true;
            this.CategoryListBox.Location = new System.Drawing.Point(12, 49);
            this.CategoryListBox.Name = "CategoryListBox";
            this.CategoryListBox.Size = new System.Drawing.Size(231, 212);
            this.CategoryListBox.TabIndex = 1;
            this.CategoryListBox.SelectedIndexChanged += new System.EventHandler(this.CategoryListBox_SelectedIndexChanged);
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.Location = new System.Drawing.Point(83, 267);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new System.Drawing.Size(96, 23);
            this.AddCategoryButton.TabIndex = 2;
            this.AddCategoryButton.Text = "Add Category";
            this.AddCategoryButton.UseVisualStyleBackColor = true;
            this.AddCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // CategoryDataTabs
            // 
            this.CategoryDataTabs.Controls.Add(this.OverviewTab);
            this.CategoryDataTabs.Controls.Add(this.CategoryDetailsTab);
            this.CategoryDataTabs.Location = new System.Drawing.Point(249, 27);
            this.CategoryDataTabs.Name = "CategoryDataTabs";
            this.CategoryDataTabs.SelectedIndex = 0;
            this.CategoryDataTabs.Size = new System.Drawing.Size(539, 316);
            this.CategoryDataTabs.TabIndex = 3;
            // 
            // OverviewTab
            // 
            this.OverviewTab.Controls.Add(this.CategoryChart);
            this.OverviewTab.Location = new System.Drawing.Point(4, 22);
            this.OverviewTab.Name = "OverviewTab";
            this.OverviewTab.Padding = new System.Windows.Forms.Padding(3);
            this.OverviewTab.Size = new System.Drawing.Size(531, 290);
            this.OverviewTab.TabIndex = 0;
            this.OverviewTab.Text = "Overview";
            this.OverviewTab.UseVisualStyleBackColor = true;
            // 
            // CategoryChart
            // 
            chartArea2.Name = "ChartArea1";
            this.CategoryChart.ChartAreas.Add(chartArea2);
            this.CategoryChart.Enabled = false;
            legend2.Name = "Legend1";
            this.CategoryChart.Legends.Add(legend2);
            this.CategoryChart.Location = new System.Drawing.Point(6, 6);
            this.CategoryChart.Name = "CategoryChart";
            this.CategoryChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series3.Legend = "Legend1";
            series3.LegendText = "Study Time";
            series3.Name = "StudyTime";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series4.Legend = "Legend1";
            series4.LegendText = "Practice Time";
            series4.Name = "PracticeTime";
            this.CategoryChart.Series.Add(series3);
            this.CategoryChart.Series.Add(series4);
            this.CategoryChart.Size = new System.Drawing.Size(519, 278);
            this.CategoryChart.TabIndex = 0;
            this.CategoryChart.Text = "chart1";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.Name = "Title1";
            title4.Text = "Total Time Spent per Category";
            title5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title5.Name = "Title2";
            title5.Text = "Hours";
            title5.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270;
            title6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title6.Name = "Title3";
            title6.Text = "Category";
            this.CategoryChart.Titles.Add(title4);
            this.CategoryChart.Titles.Add(title5);
            this.CategoryChart.Titles.Add(title6);
            this.CategoryChart.UseWaitCursor = true;
            // 
            // CategoryDetailsTab
            // 
            this.CategoryDetailsTab.Controls.Add(this.CategoryDetailGroupBox);
            this.CategoryDetailsTab.Location = new System.Drawing.Point(4, 22);
            this.CategoryDetailsTab.Name = "CategoryDetailsTab";
            this.CategoryDetailsTab.Padding = new System.Windows.Forms.Padding(3);
            this.CategoryDetailsTab.Size = new System.Drawing.Size(531, 290);
            this.CategoryDetailsTab.TabIndex = 1;
            this.CategoryDetailsTab.Text = "Details";
            this.CategoryDetailsTab.UseVisualStyleBackColor = true;
            // 
            // CategoryDetailGroupBox
            // 
            this.CategoryDetailGroupBox.Controls.Add(this.SessionDetailsGroupBox);
            this.CategoryDetailGroupBox.Controls.Add(this.RecentActivityGroupBox);
            this.CategoryDetailGroupBox.Controls.Add(this.TotalsGroupBox);
            this.CategoryDetailGroupBox.Location = new System.Drawing.Point(6, 6);
            this.CategoryDetailGroupBox.Name = "CategoryDetailGroupBox";
            this.CategoryDetailGroupBox.Size = new System.Drawing.Size(519, 278);
            this.CategoryDetailGroupBox.TabIndex = 0;
            this.CategoryDetailGroupBox.TabStop = false;
            this.CategoryDetailGroupBox.Text = "--";
            // 
            // SessionDetailsGroupBox
            // 
            this.SessionDetailsGroupBox.Location = new System.Drawing.Point(297, 85);
            this.SessionDetailsGroupBox.Name = "SessionDetailsGroupBox";
            this.SessionDetailsGroupBox.Size = new System.Drawing.Size(216, 187);
            this.SessionDetailsGroupBox.TabIndex = 2;
            this.SessionDetailsGroupBox.TabStop = false;
            this.SessionDetailsGroupBox.Text = "Session Details";
            // 
            // RecentActivityGroupBox
            // 
            this.RecentActivityGroupBox.Controls.Add(this.RecentActivityListBox);
            this.RecentActivityGroupBox.Controls.Add(this.AddPracticeTimeSession);
            this.RecentActivityGroupBox.Controls.Add(this.AddStudyTimeButton);
            this.RecentActivityGroupBox.Location = new System.Drawing.Point(6, 19);
            this.RecentActivityGroupBox.Name = "RecentActivityGroupBox";
            this.RecentActivityGroupBox.Size = new System.Drawing.Size(285, 253);
            this.RecentActivityGroupBox.TabIndex = 1;
            this.RecentActivityGroupBox.TabStop = false;
            this.RecentActivityGroupBox.Text = "Recent Activity";
            // 
            // RecentActivityListBox
            // 
            this.RecentActivityListBox.FormattingEnabled = true;
            this.RecentActivityListBox.Location = new System.Drawing.Point(6, 48);
            this.RecentActivityListBox.Name = "RecentActivityListBox";
            this.RecentActivityListBox.Size = new System.Drawing.Size(273, 199);
            this.RecentActivityListBox.TabIndex = 2;
            // 
            // AddPracticeTimeSession
            // 
            this.AddPracticeTimeSession.Location = new System.Drawing.Point(146, 19);
            this.AddPracticeTimeSession.Name = "AddPracticeTimeSession";
            this.AddPracticeTimeSession.Size = new System.Drawing.Size(123, 23);
            this.AddPracticeTimeSession.TabIndex = 1;
            this.AddPracticeTimeSession.Text = "Add Practice Session";
            this.AddPracticeTimeSession.UseVisualStyleBackColor = true;
            // 
            // AddStudyTimeButton
            // 
            this.AddStudyTimeButton.Location = new System.Drawing.Point(15, 19);
            this.AddStudyTimeButton.Name = "AddStudyTimeButton";
            this.AddStudyTimeButton.Size = new System.Drawing.Size(123, 23);
            this.AddStudyTimeButton.TabIndex = 0;
            this.AddStudyTimeButton.Text = "Add Study Session";
            this.AddStudyTimeButton.UseVisualStyleBackColor = true;
            this.AddStudyTimeButton.Click += new System.EventHandler(this.AddStudyTimeButton_Click);
            // 
            // TotalsGroupBox
            // 
            this.TotalsGroupBox.Controls.Add(this.StudyTimeTotalValue);
            this.TotalsGroupBox.Controls.Add(this.PracticeTimeTotalValue);
            this.TotalsGroupBox.Controls.Add(this.PracticeTimeTotalLabel);
            this.TotalsGroupBox.Controls.Add(this.StudyTimeTotalLabel);
            this.TotalsGroupBox.Location = new System.Drawing.Point(297, 19);
            this.TotalsGroupBox.Name = "TotalsGroupBox";
            this.TotalsGroupBox.Size = new System.Drawing.Size(216, 60);
            this.TotalsGroupBox.TabIndex = 0;
            this.TotalsGroupBox.TabStop = false;
            this.TotalsGroupBox.Text = "Totals";
            // 
            // StudyTimeTotalValue
            // 
            this.StudyTimeTotalValue.AutoSize = true;
            this.StudyTimeTotalValue.Location = new System.Drawing.Point(88, 16);
            this.StudyTimeTotalValue.Name = "StudyTimeTotalValue";
            this.StudyTimeTotalValue.Size = new System.Drawing.Size(70, 13);
            this.StudyTimeTotalValue.TabIndex = 3;
            this.StudyTimeTotalValue.Text = "Not Available";
            // 
            // PracticeTimeTotalValue
            // 
            this.PracticeTimeTotalValue.AutoSize = true;
            this.PracticeTimeTotalValue.Location = new System.Drawing.Point(88, 33);
            this.PracticeTimeTotalValue.Name = "PracticeTimeTotalValue";
            this.PracticeTimeTotalValue.Size = new System.Drawing.Size(70, 13);
            this.PracticeTimeTotalValue.TabIndex = 2;
            this.PracticeTimeTotalValue.Text = "Not Available";
            // 
            // PracticeTimeTotalLabel
            // 
            this.PracticeTimeTotalLabel.AutoSize = true;
            this.PracticeTimeTotalLabel.Location = new System.Drawing.Point(7, 33);
            this.PracticeTimeTotalLabel.Name = "PracticeTimeTotalLabel";
            this.PracticeTimeTotalLabel.Size = new System.Drawing.Size(75, 13);
            this.PracticeTimeTotalLabel.TabIndex = 1;
            this.PracticeTimeTotalLabel.Text = "Practice Time:";
            // 
            // StudyTimeTotalLabel
            // 
            this.StudyTimeTotalLabel.AutoSize = true;
            this.StudyTimeTotalLabel.Location = new System.Drawing.Point(7, 16);
            this.StudyTimeTotalLabel.Name = "StudyTimeTotalLabel";
            this.StudyTimeTotalLabel.Size = new System.Drawing.Size(63, 13);
            this.StudyTimeTotalLabel.TabIndex = 0;
            this.StudyTimeTotalLabel.Text = "Study Time:";
            // 
            // trainingsBindingSource
            // 
            this.trainingsBindingSource.DataMember = "Trainings";
            this.trainingsBindingSource.DataSource = this.categoryModelBindingSource;
            // 
            // categoryModelBindingSource
            // 
            this.categoryModelBindingSource.DataSource = typeof(JournalLibrary.Models.CategoryModel);
            // 
            // DevOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 355);
            this.Controls.Add(this.CategoryDataTabs);
            this.Controls.Add(this.AddCategoryButton);
            this.Controls.Add(this.CategoryListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DevOverviewForm";
            this.Text = "Development Jounal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.CategoryDataTabs.ResumeLayout(false);
            this.OverviewTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryChart)).EndInit();
            this.CategoryDetailsTab.ResumeLayout(false);
            this.CategoryDetailGroupBox.ResumeLayout(false);
            this.RecentActivityGroupBox.ResumeLayout(false);
            this.TotalsGroupBox.ResumeLayout(false);
            this.TotalsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripHeader;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libraryToolStripHeader;
        private System.Windows.Forms.ToolStripMenuItem viewBooksToolStripLibraryItem;
        private System.Windows.Forms.ToolStripMenuItem viewOnlineCoursesToolStripMenuItem;
        private System.Windows.Forms.ListBox CategoryListBox;
        private System.Windows.Forms.Button AddCategoryButton;
        private System.Windows.Forms.TabControl CategoryDataTabs;
        private System.Windows.Forms.TabPage OverviewTab;
        private System.Windows.Forms.TabPage CategoryDetailsTab;
        private System.Windows.Forms.GroupBox CategoryDetailGroupBox;
        private System.Windows.Forms.GroupBox TotalsGroupBox;
        private System.Windows.Forms.Label StudyTimeTotalValue;
        private System.Windows.Forms.Label PracticeTimeTotalValue;
        private System.Windows.Forms.Label PracticeTimeTotalLabel;
        private System.Windows.Forms.Label StudyTimeTotalLabel;
        private System.Windows.Forms.GroupBox RecentActivityGroupBox;
        private System.Windows.Forms.Button AddPracticeTimeSession;
        private System.Windows.Forms.Button AddStudyTimeButton;
        private System.Windows.Forms.ListBox RecentActivityListBox;
        private System.Windows.Forms.GroupBox SessionDetailsGroupBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart CategoryChart;
        private System.Windows.Forms.BindingSource categoryModelBindingSource;
        private System.Windows.Forms.BindingSource trainingsBindingSource;
    }
}