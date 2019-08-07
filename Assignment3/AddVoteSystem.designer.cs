namespace Agile_Assignment_3
{
    partial class AddVoteSystem
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
            this.CandidateLabel = new System.Windows.Forms.Label();
            this.CreateVoteButton = new System.Windows.Forms.Button();
            this.CandidateListBox = new System.Windows.Forms.ListBox();
            this.validVoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EndVoteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.validVoteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CandidateLabel
            // 
            this.CandidateLabel.AutoSize = true;
            this.CandidateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CandidateLabel.Location = new System.Drawing.Point(60, 20);
            this.CandidateLabel.Name = "CandidateLabel";
            this.CandidateLabel.Size = new System.Drawing.Size(64, 13);
            this.CandidateLabel.TabIndex = 1;
            this.CandidateLabel.Text = "Candidate";
            // 
            // CreateVoteButton
            // 
            this.CreateVoteButton.Location = new System.Drawing.Point(43, 259);
            this.CreateVoteButton.Name = "CreateVoteButton";
            this.CreateVoteButton.Size = new System.Drawing.Size(98, 23);
            this.CreateVoteButton.TabIndex = 2;
            this.CreateVoteButton.Text = "Create new vote";
            this.CreateVoteButton.UseVisualStyleBackColor = true;
            this.CreateVoteButton.Click += new System.EventHandler(this.CreateVoteButton_Click);
            // 
            // CandidateListBox
            // 
            this.CandidateListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CandidateListBox.ForeColor = System.Drawing.Color.CadetBlue;
            this.CandidateListBox.FormattingEnabled = true;
            this.CandidateListBox.HorizontalScrollbar = true;
            this.CandidateListBox.Location = new System.Drawing.Point(23, 46);
            this.CandidateListBox.Name = "CandidateListBox";
            this.CandidateListBox.Size = new System.Drawing.Size(133, 199);
            this.CandidateListBox.TabIndex = 4;
            // 
            // EndVoteButton
            // 
            this.EndVoteButton.Location = new System.Drawing.Point(43, 287);
            this.EndVoteButton.Name = "EndVoteButton";
            this.EndVoteButton.Size = new System.Drawing.Size(98, 23);
            this.EndVoteButton.TabIndex = 5;
            this.EndVoteButton.Text = "End Session";
            this.EndVoteButton.UseVisualStyleBackColor = true;
            this.EndVoteButton.Click += new System.EventHandler(this.EndVoteButton_Click);
            // 
            // AddVoteSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 322);
            this.Controls.Add(this.EndVoteButton);
            this.Controls.Add(this.CandidateListBox);
            this.Controls.Add(this.CreateVoteButton);
            this.Controls.Add(this.CandidateLabel);
            this.Name = "AddVoteSystem";
            this.Text = "AddVoteSystem";
            this.Load += new System.EventHandler(this.AddVoteSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.validVoteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource validVoteBindingSource;
        private System.Windows.Forms.Label CandidateLabel;
        private System.Windows.Forms.Button CreateVoteButton;
        internal System.Windows.Forms.ListBox CandidateListBox;
        private System.Windows.Forms.Button EndVoteButton;
    }
}