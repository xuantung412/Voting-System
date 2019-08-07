namespace Agile_Assignment_3
{
    partial class PageResultContainer
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.Print = new System.Windows.Forms.ToolStripMenuItem();
            this.PrinterPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResultViews = new System.Windows.Forms.ToolStripMenuItem();
            this.RoundViews = new System.Windows.Forms.ToolStripMenuItem();
            this.SummaryView = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Print,
            this.ResultViews});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(0);
            this.MenuStrip.Size = new System.Drawing.Size(284, 24);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // Print
            // 
            this.Print.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrinterPrint,
            this.exportAsToolStripMenuItem});
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(44, 24);
            this.Print.Text = "Print";
            // 
            // PrinterPrint
            // 
            this.PrinterPrint.Name = "PrinterPrint";
            this.PrinterPrint.Size = new System.Drawing.Size(139, 22);
            this.PrinterPrint.Text = "Print";
            this.PrinterPrint.Click += new System.EventHandler(this.PrinterPrint_Click);
            // 
            // exportAsToolStripMenuItem
            // 
            this.exportAsToolStripMenuItem.Name = "exportAsToolStripMenuItem";
            this.exportAsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.exportAsToolStripMenuItem.Text = "Export";
            this.exportAsToolStripMenuItem.Click += new System.EventHandler(this.exportAsToolStripMenuItem_Click);
            // 
            // ResultViews
            // 
            this.ResultViews.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RoundViews,
            this.SummaryView});
            this.ResultViews.Name = "ResultViews";
            this.ResultViews.Size = new System.Drawing.Size(84, 24);
            this.ResultViews.Text = "Result Views";
            // 
            // RoundViews
            // 
            this.RoundViews.Name = "RoundViews";
            this.RoundViews.Size = new System.Drawing.Size(153, 22);
            this.RoundViews.Text = "Round Views";
            this.RoundViews.Click += new System.EventHandler(this.RoundViews_Click);
            // 
            // SummaryView
            // 
            this.SummaryView.Name = "SummaryView";
            this.SummaryView.Size = new System.Drawing.Size(153, 22);
            this.SummaryView.Text = "Summary View";
            this.SummaryView.Click += new System.EventHandler(this.SummaryView_Click);
            // 
            // PageResultContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.MenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "PageResultContainer";
            this.Text = "Voting Results";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Print;
        private System.Windows.Forms.ToolStripMenuItem PrinterPrint;
        private System.Windows.Forms.ToolStripMenuItem ResultViews;
        private System.Windows.Forms.ToolStripMenuItem RoundViews;
        private System.Windows.Forms.ToolStripMenuItem SummaryView;
        private System.Windows.Forms.ToolStripMenuItem exportAsToolStripMenuItem;
    }
}