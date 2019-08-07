namespace Agile_Assignment_3
{
    partial class ResultSummaryPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListView = new System.Windows.Forms.ListView();
            this.Candidates = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ValidBallotPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.InvalidBallotLabel = new System.Windows.Forms.Label();
            this.ExhaustedBallotPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TotalBallotLabel = new System.Windows.Forms.Label();
            this.MajorityPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Result Summary";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(522, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Round";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListView
            // 
            this.ListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.ListView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Candidates});
            this.ListView.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView.GridLines = true;
            this.ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListView.Location = new System.Drawing.Point(42, 81);
            this.ListView.MultiSelect = false;
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(752, 160);
            this.ListView.TabIndex = 2;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            // 
            // Candidates
            // 
            this.Candidates.Text = "Candidates";
            this.Candidates.Width = 229;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Invalid Ballots:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Exhausted Ballots:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Valid Ballots:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total Ballots:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Majority:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ValidBallotPanel
            // 
            this.ValidBallotPanel.AutoScroll = true;
            this.ValidBallotPanel.Location = new System.Drawing.Point(274, 240);
            this.ValidBallotPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ValidBallotPanel.Name = "ValidBallotPanel";
            this.ValidBallotPanel.Size = new System.Drawing.Size(520, 24);
            this.ValidBallotPanel.TabIndex = 8;
            // 
            // InvalidBallotLabel
            // 
            this.InvalidBallotLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InvalidBallotLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidBallotLabel.Location = new System.Drawing.Point(274, 263);
            this.InvalidBallotLabel.Margin = new System.Windows.Forms.Padding(0);
            this.InvalidBallotLabel.Name = "InvalidBallotLabel";
            this.InvalidBallotLabel.Size = new System.Drawing.Size(520, 24);
            this.InvalidBallotLabel.TabIndex = 9;
            this.InvalidBallotLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExhaustedBallotPanel
            // 
            this.ExhaustedBallotPanel.AutoScroll = true;
            this.ExhaustedBallotPanel.Location = new System.Drawing.Point(274, 286);
            this.ExhaustedBallotPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ExhaustedBallotPanel.Name = "ExhaustedBallotPanel";
            this.ExhaustedBallotPanel.Size = new System.Drawing.Size(520, 24);
            this.ExhaustedBallotPanel.TabIndex = 10;
            // 
            // TotalBallotLabel
            // 
            this.TotalBallotLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalBallotLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBallotLabel.Location = new System.Drawing.Point(274, 309);
            this.TotalBallotLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TotalBallotLabel.Name = "TotalBallotLabel";
            this.TotalBallotLabel.Size = new System.Drawing.Size(520, 24);
            this.TotalBallotLabel.TabIndex = 11;
            this.TotalBallotLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MajorityPanel
            // 
            this.MajorityPanel.AutoScroll = true;
            this.MajorityPanel.Location = new System.Drawing.Point(274, 332);
            this.MajorityPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MajorityPanel.Name = "MajorityPanel";
            this.MajorityPanel.Size = new System.Drawing.Size(520, 24);
            this.MajorityPanel.TabIndex = 11;
            // 
            // OK
            // 
            this.OK.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.Location = new System.Drawing.Point(383, 365);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 31);
            this.OK.TabIndex = 12;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // ResultSummaryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 400);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.MajorityPanel);
            this.Controls.Add(this.TotalBallotLabel);
            this.Controls.Add(this.ExhaustedBallotPanel);
            this.Controls.Add(this.InvalidBallotLabel);
            this.Controls.Add(this.ValidBallotPanel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(840, 400);
            this.MinimumSize = new System.Drawing.Size(840, 400);
            this.Name = "ResultSummaryPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ResultSummaryPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.ColumnHeader Candidates;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel ValidBallotPanel;
        private System.Windows.Forms.Label InvalidBallotLabel;
        private System.Windows.Forms.FlowLayoutPanel ExhaustedBallotPanel;
        private System.Windows.Forms.Label TotalBallotLabel;
        private System.Windows.Forms.FlowLayoutPanel MajorityPanel;
        private System.Windows.Forms.Button OK;
    }
}