namespace DevJournalUI.ViewElementForms
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
            // DevOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}