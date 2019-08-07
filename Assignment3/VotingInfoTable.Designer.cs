namespace Agile_Assignment_3
{
    partial class VotingInfoTable
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
            this.NamePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PreferencePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // NamePanel
            // 
            this.NamePanel.Location = new System.Drawing.Point(0, 0);
            this.NamePanel.Margin = new System.Windows.Forms.Padding(0);
            this.NamePanel.Name = "NamePanel";
            this.NamePanel.Size = new System.Drawing.Size(400, 40);
            this.NamePanel.TabIndex = 0;
            // 
            // PreferencePanel
            // 
            this.PreferencePanel.Location = new System.Drawing.Point(0, 39);
            this.PreferencePanel.Margin = new System.Windows.Forms.Padding(0);
            this.PreferencePanel.Name = "PreferencePanel";
            this.PreferencePanel.Size = new System.Drawing.Size(400, 41);
            this.PreferencePanel.TabIndex = 1;
            // 
            // VotingInfoTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(400, 80);
            this.Controls.Add(this.PreferencePanel);
            this.Controls.Add(this.NamePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(400, 80);
            this.MinimumSize = new System.Drawing.Size(400, 80);
            this.Name = "VotingInfoTable";
            this.ShowInTaskbar = false;
            this.Text = "VotingInfoTable";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel NamePanel;
        private System.Windows.Forms.FlowLayoutPanel PreferencePanel;
    }
}