namespace Agile_Assignment_3
{
    partial class RoundResultPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoundResultPage));
            this.PreviousPageSwitch = new System.Windows.Forms.PictureBox();
            this.NextPageSwitch = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ValidBallotLabel = new System.Windows.Forms.Label();
            this.InvalidBallotLabel = new System.Windows.Forms.Label();
            this.ExhaustedBallotLabel = new System.Windows.Forms.Label();
            this.TotalBallotLabel = new System.Windows.Forms.Label();
            this.MajorityLabel = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TablePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousPageSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextPageSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // PreviousPageSwitch
            // 
            this.PreviousPageSwitch.Image = ((System.Drawing.Image)(resources.GetObject("PreviousPageSwitch.Image")));
            this.PreviousPageSwitch.Location = new System.Drawing.Point(12, 12);
            this.PreviousPageSwitch.Name = "PreviousPageSwitch";
            this.PreviousPageSwitch.Size = new System.Drawing.Size(64, 64);
            this.PreviousPageSwitch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PreviousPageSwitch.TabIndex = 0;
            this.PreviousPageSwitch.TabStop = false;
            this.PreviousPageSwitch.Click += new System.EventHandler(this.PreviousPageSwitch_Click);
            // 
            // NextPageSwitch
            // 
            this.NextPageSwitch.Image = ((System.Drawing.Image)(resources.GetObject("NextPageSwitch.Image")));
            this.NextPageSwitch.Location = new System.Drawing.Point(765, 12);
            this.NextPageSwitch.Name = "NextPageSwitch";
            this.NextPageSwitch.Size = new System.Drawing.Size(64, 64);
            this.NextPageSwitch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.NextPageSwitch.TabIndex = 1;
            this.NextPageSwitch.TabStop = false;
            this.NextPageSwitch.Click += new System.EventHandler(this.NextPageSwitch_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(339, 36);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(0, 25);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.TextChanged += new System.EventHandler(this.TitleLabel_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 171);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(148, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valid Voting Ballots:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 207);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(160, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Invalid Voting Ballots:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 243);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(180, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Exhausted Voting Ballots:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 279);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(146, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Voting Ballots:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 315);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Majority:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ValidBallotLabel
            // 
            this.ValidBallotLabel.AutoSize = true;
            this.ValidBallotLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidBallotLabel.Location = new System.Drawing.Point(217, 159);
            this.ValidBallotLabel.Name = "ValidBallotLabel";
            this.ValidBallotLabel.Size = new System.Drawing.Size(0, 18);
            this.ValidBallotLabel.TabIndex = 10;
            // 
            // InvalidBallotLabel
            // 
            this.InvalidBallotLabel.AutoSize = true;
            this.InvalidBallotLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidBallotLabel.Location = new System.Drawing.Point(217, 195);
            this.InvalidBallotLabel.Name = "InvalidBallotLabel";
            this.InvalidBallotLabel.Size = new System.Drawing.Size(0, 18);
            this.InvalidBallotLabel.TabIndex = 11;
            // 
            // ExhaustedBallotLabel
            // 
            this.ExhaustedBallotLabel.AutoSize = true;
            this.ExhaustedBallotLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExhaustedBallotLabel.Location = new System.Drawing.Point(217, 231);
            this.ExhaustedBallotLabel.Name = "ExhaustedBallotLabel";
            this.ExhaustedBallotLabel.Size = new System.Drawing.Size(0, 18);
            this.ExhaustedBallotLabel.TabIndex = 12;
            // 
            // TotalBallotLabel
            // 
            this.TotalBallotLabel.AutoSize = true;
            this.TotalBallotLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBallotLabel.Location = new System.Drawing.Point(217, 267);
            this.TotalBallotLabel.Name = "TotalBallotLabel";
            this.TotalBallotLabel.Size = new System.Drawing.Size(0, 18);
            this.TotalBallotLabel.TabIndex = 13;
            // 
            // MajorityLabel
            // 
            this.MajorityLabel.AutoSize = true;
            this.MajorityLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MajorityLabel.Location = new System.Drawing.Point(217, 303);
            this.MajorityLabel.Name = "MajorityLabel";
            this.MajorityLabel.Size = new System.Drawing.Size(0, 18);
            this.MajorityLabel.TabIndex = 14;
            // 
            // OK
            // 
            this.OK.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.Location = new System.Drawing.Point(361, 349);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 26);
            this.OK.TabIndex = 16;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Chart
            // 
            this.Chart.BackColor = System.Drawing.Color.Transparent;
            this.Chart.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Wave;
            this.Chart.Location = new System.Drawing.Point(449, 82);
            this.Chart.Name = "Chart";
            this.Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.Chart.Size = new System.Drawing.Size(380, 230);
            this.Chart.TabIndex = 17;
            this.Chart.Text = "Chart";
            // 
            // TablePanel
            // 
            this.TablePanel.Location = new System.Drawing.Point(12, 82);
            this.TablePanel.Name = "TablePanel";
            this.TablePanel.Size = new System.Drawing.Size(400, 80);
            this.TablePanel.TabIndex = 18;
            // 
            // RoundResultPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 400);
            this.Controls.Add(this.TablePanel);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.MajorityLabel);
            this.Controls.Add(this.TotalBallotLabel);
            this.Controls.Add(this.ExhaustedBallotLabel);
            this.Controls.Add(this.InvalidBallotLabel);
            this.Controls.Add(this.ValidBallotLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.NextPageSwitch);
            this.Controls.Add(this.PreviousPageSwitch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(840, 400);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "RoundResultPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RoundResultPage";
            ((System.ComponentModel.ISupportInitialize)(this.PreviousPageSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextPageSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ValidBallotLabel;
        private System.Windows.Forms.Label InvalidBallotLabel;
        private System.Windows.Forms.Label ExhaustedBallotLabel;
        private System.Windows.Forms.Label TotalBallotLabel;
        private System.Windows.Forms.Label MajorityLabel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.Panel TablePanel;
        internal System.Windows.Forms.PictureBox PreviousPageSwitch;
        internal System.Windows.Forms.PictureBox NextPageSwitch;
    }
}