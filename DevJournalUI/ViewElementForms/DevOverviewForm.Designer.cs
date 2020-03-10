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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripHeader = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryToolStripHeader = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBooksToolStripLibraryItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.categoriesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HoursStudiedLabel = new System.Windows.Forms.Label();
            this.HoursStudiedTextBox = new System.Windows.Forms.TextBox();
            this.BookStudiedLabel = new System.Windows.Forms.Label();
            this.BookReadTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuExitOption_Click);
            // 
            // libraryToolStripHeader
            // 
            this.libraryToolStripHeader.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewBooksToolStripLibraryItem});
            this.libraryToolStripHeader.Name = "libraryToolStripHeader";
            this.libraryToolStripHeader.Size = new System.Drawing.Size(55, 20);
            this.libraryToolStripHeader.Text = "Library";
            // 
            // viewBooksToolStripLibraryItem
            // 
            this.viewBooksToolStripLibraryItem.Name = "viewBooksToolStripLibraryItem";
            this.viewBooksToolStripLibraryItem.Size = new System.Drawing.Size(180, 22);
            this.viewBooksToolStripLibraryItem.Text = "View Books";
            this.viewBooksToolStripLibraryItem.Click += new System.EventHandler(this.viewBooksToolStripLibraryItem_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "d MMMM yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(497, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(194, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // categoriesListBox
            // 
            this.categoriesListBox.FormattingEnabled = true;
            this.categoriesListBox.Location = new System.Drawing.Point(12, 74);
            this.categoriesListBox.Name = "categoriesListBox";
            this.categoriesListBox.Size = new System.Drawing.Size(200, 108);
            this.categoriesListBox.TabIndex = 2;
            this.categoriesListBox.SelectedIndexChanged += new System.EventHandler(this.categoriesListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // HoursStudiedLabel
            // 
            this.HoursStudiedLabel.AutoSize = true;
            this.HoursStudiedLabel.Location = new System.Drawing.Point(455, 127);
            this.HoursStudiedLabel.Name = "HoursStudiedLabel";
            this.HoursStudiedLabel.Size = new System.Drawing.Size(77, 13);
            this.HoursStudiedLabel.TabIndex = 4;
            this.HoursStudiedLabel.Text = "Hours Studied:";
            // 
            // HoursStudiedTextBox
            // 
            this.HoursStudiedTextBox.Location = new System.Drawing.Point(538, 124);
            this.HoursStudiedTextBox.Name = "HoursStudiedTextBox";
            this.HoursStudiedTextBox.Size = new System.Drawing.Size(100, 20);
            this.HoursStudiedTextBox.TabIndex = 5;
            // 
            // BookStudiedLabel
            // 
            this.BookStudiedLabel.AutoSize = true;
            this.BookStudiedLabel.Location = new System.Drawing.Point(468, 153);
            this.BookStudiedLabel.Name = "BookStudiedLabel";
            this.BookStudiedLabel.Size = new System.Drawing.Size(64, 13);
            this.BookStudiedLabel.TabIndex = 6;
            this.BookStudiedLabel.Text = "Book Read:";
            // 
            // BookReadTextBox
            // 
            this.BookReadTextBox.Location = new System.Drawing.Point(538, 150);
            this.BookReadTextBox.Name = "BookReadTextBox";
            this.BookReadTextBox.Size = new System.Drawing.Size(100, 20);
            this.BookReadTextBox.TabIndex = 7;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(538, 189);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DevOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BookReadTextBox);
            this.Controls.Add(this.BookStudiedLabel);
            this.Controls.Add(this.HoursStudiedTextBox);
            this.Controls.Add(this.HoursStudiedLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoriesListBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DevOverviewForm";
            this.Text = "Development Jounal Overview";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripHeader;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libraryToolStripHeader;
        private System.Windows.Forms.ToolStripMenuItem viewBooksToolStripLibraryItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox categoriesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HoursStudiedLabel;
        private System.Windows.Forms.TextBox HoursStudiedTextBox;
        private System.Windows.Forms.Label BookStudiedLabel;
        private System.Windows.Forms.TextBox BookReadTextBox;
        private System.Windows.Forms.Button SaveButton;
    }
}