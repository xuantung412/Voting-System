namespace Agile_Assignment_3
{
    partial class InputCandidate
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
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NameCandidateTextBox = new System.Windows.Forms.TextBox();
            this.CandidateListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.StartVoteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(151, 51);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Candidate Name";
            // 
            // NameCandidateTextBox
            // 
            this.NameCandidateTextBox.Location = new System.Drawing.Point(15, 25);
            this.NameCandidateTextBox.Name = "NameCandidateTextBox";
            this.NameCandidateTextBox.Size = new System.Drawing.Size(211, 20);
            this.NameCandidateTextBox.TabIndex = 2;
            // 
            // CandidateListBox
            // 
            this.CandidateListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CandidateListBox.ForeColor = System.Drawing.Color.CadetBlue;
            this.CandidateListBox.FormattingEnabled = true;
            this.CandidateListBox.HorizontalScrollbar = true;
            this.CandidateListBox.Location = new System.Drawing.Point(15, 111);
            this.CandidateListBox.Name = "CandidateListBox";
            this.CandidateListBox.Size = new System.Drawing.Size(211, 225);
            this.CandidateListBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Candidate";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(41, 342);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(168, 23);
            this.RemoveButton.TabIndex = 5;
            this.RemoveButton.Text = "Remove Selected Candidate";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // StartVoteButton
            // 
            this.StartVoteButton.Location = new System.Drawing.Point(87, 371);
            this.StartVoteButton.Name = "StartVoteButton";
            this.StartVoteButton.Size = new System.Drawing.Size(75, 23);
            this.StartVoteButton.TabIndex = 6;
            this.StartVoteButton.Text = "Start Vote";
            this.StartVoteButton.UseVisualStyleBackColor = true;
            this.StartVoteButton.Click += new System.EventHandler(this.StartVoteButton_Click);
            // 
            // InputCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 406);
            this.Controls.Add(this.StartVoteButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CandidateListBox);
            this.Controls.Add(this.NameCandidateTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddButton);
            this.Name = "InputCandidate";
            this.Text = "InputCandidate";
            this.Load += new System.EventHandler(this.InputCandidate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameCandidateTextBox;
        internal System.Windows.Forms.ListBox CandidateListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button StartVoteButton;
    }
}