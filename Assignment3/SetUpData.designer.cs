namespace Agile_Assignment_3
{
    partial class SetUpData
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ManuallyButtonButton = new System.Windows.Forms.Button();
            this.ImportCSVButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ShowResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(64, 22);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(170, 13);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Please chose to set up data.";
            // 
            // ManuallyButtonButton
            // 
            this.ManuallyButtonButton.Location = new System.Drawing.Point(105, 67);
            this.ManuallyButtonButton.Name = "ManuallyButtonButton";
            this.ManuallyButtonButton.Size = new System.Drawing.Size(75, 23);
            this.ManuallyButtonButton.TabIndex = 1;
            this.ManuallyButtonButton.Text = "Manually";
            this.ManuallyButtonButton.UseVisualStyleBackColor = true;
            this.ManuallyButtonButton.Click += new System.EventHandler(this.ManuallyButtonButton_Click);
            // 
            // ImportCSVButton
            // 
            this.ImportCSVButton.Location = new System.Drawing.Point(159, 35);
            this.ImportCSVButton.Name = "ImportCSVButton";
            this.ImportCSVButton.Size = new System.Drawing.Size(75, 23);
            this.ImportCSVButton.TabIndex = 2;
            this.ImportCSVButton.Text = "Import CSV";
            this.ImportCSVButton.UseVisualStyleBackColor = true;
            this.ImportCSVButton.Click += new System.EventHandler(this.ImportCSVButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(22, 111);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(250, 381);
            this.listBox1.TabIndex = 3;
            // 
            // ShowResult
            // 
            this.ShowResult.Location = new System.Drawing.Point(67, 36);
            this.ShowResult.Margin = new System.Windows.Forms.Padding(0);
            this.ShowResult.Name = "ShowResult";
            this.ShowResult.Size = new System.Drawing.Size(76, 23);
            this.ShowResult.TabIndex = 6;
            this.ShowResult.Text = "Show Result";
            this.ShowResult.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ShowResult.UseVisualStyleBackColor = true;
            this.ShowResult.Visible = false;
            this.ShowResult.Click += new System.EventHandler(this.ShowResult_Click);
            // 
            // SetUpData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 502);
            this.Controls.Add(this.ShowResult);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ImportCSVButton);
            this.Controls.Add(this.ManuallyButtonButton);
            this.Controls.Add(this.TitleLabel);
            this.Name = "SetUpData";
            this.Text = "Set up data.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button ManuallyButtonButton;
        private System.Windows.Forms.Button ImportCSVButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ShowResult;
    }
}

