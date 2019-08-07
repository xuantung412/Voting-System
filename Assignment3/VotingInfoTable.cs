using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Agile_Assignment_3
{
    public partial class VotingInfoTable : Form
    {
        List<Label> CandidatesLabels = new List<Label>();
        List<TextBox> PreferenceLabels = new List<TextBox>();
        bool IsReadOnly;
        public VotingInfoTable(List<string> Candidates, List<int> Preferences, bool ReadOnly)
        {
            InitializeComponent();
            this.IsReadOnly = ReadOnly;
            this.LoadVotingInfoTable(Candidates, Preferences);
            this.Top = 0;
            this.Left = 0;
            this.TopLevel = false;
            this.Show();
        }

        private void LoadVotingInfoTable(List<string> Candidates, List<int> Preferences)
        {
            if (Candidates.Count > this.NamePanel.Width / 50)
            {
                this.NamePanel.Size = new Size(Candidates.Count * 50, this.NamePanel.Height);
                this.PreferencePanel.Size = new Size(Candidates.Count * 50, this.PreferencePanel.Height);
            }   
            for(int i = 0; i < Candidates.Count; i++)
            {
                Label Name = new Label();
                Name.AutoSize = false;
                Name.Text = Candidates[i];
                if (Candidates.Count > this.NamePanel.Width / 50)
                    Name.Size = new Size(50, this.NamePanel.Height);
                else
                    Name.Size = new Size(this.NamePanel.Width / Candidates.Count, this.NamePanel.Height);
                Name.Font = new Font("Modern No. 20", 10, FontStyle.Bold);
                Name.TextAlign = ContentAlignment.MiddleCenter;
                Name.Margin = new Padding(0);

                TextBox Preference = new TextBox();
                Preference.Text = (Preferences != null? (Preferences[i] > 0? Preferences[i].ToString() : "P") : "");
                if(Candidates.Count > this.PreferencePanel.Width / 50)
                    Preference.Size = new Size(50, this.PreferencePanel.Height);
                else
                    Preference.Size = new Size(this.PreferencePanel.Width / Candidates.Count, this.PreferencePanel.Height);
                Preference.Font = new Font("Modern No. 20", 10);
                Preference.TextAlign = HorizontalAlignment.Center;
                Preference.Margin = new Padding(0);
                Preference.KeyPress += new KeyPressEventHandler(KeyPress);
                Preference.ReadOnly = this.IsReadOnly;

                this.CandidatesLabels.Add(Name);
                this.NamePanel.Controls.Add(Name);
                this.PreferenceLabels.Add(Preference);
                this.PreferencePanel.Controls.Add(Preference);
            }
        }

        public List<int> GetPreferenceInput()
        {
            List<int> Input = new List<int>();
            foreach (TextBox TextBox in this.PreferenceLabels)
                Input.Add((TextBox.Text != ""? int.Parse(TextBox.Text) : 0));
            return Input;
        }

        private void KeyPress(Object sender, KeyPressEventArgs e)
        {
            if (!(Convert.ToInt16(e.KeyChar) >= 48 && Convert.ToInt16(e.KeyChar) <= 57) && Convert.ToInt16(e.KeyChar) != 8)
                e.Handled = true;
        }
    }
}
