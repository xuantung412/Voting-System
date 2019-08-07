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
    public partial class ResultSummaryPage : Form
    {
        public ResultSummaryPage(List<Dictionary<string, int>> Results, List<int> RoundValidBallots,
                                    int InvalidBallots, List<int> RoundExhaustedBallots, 
                                    int TotalBallots, List<int> RoundMajority)
        {
            InitializeComponent();
            this.SetupSummaryTable(Results);
            this.SetupBallotInforLabels(RoundValidBallots, InvalidBallots, RoundExhaustedBallots,
                                        TotalBallots, RoundMajority);
            this.Show();
        }

        private void SetupSummaryTable(List<Dictionary<string, int>> Results)
        {
            foreach (KeyValuePair<string, int> Result in Results[0])
            {
                ListViewItem Item = new ListViewItem(Result.Key);
                this.ListView.Items.Add(Item);
                foreach (Dictionary<string, int> Round in Results)
                {
                    ListViewItem.ListViewSubItem SubItem = new ListViewItem.ListViewSubItem(Item, Round[Result.Key].ToString());
                    Item.SubItems.Add(SubItem);
                }
               
            }

            for(int i = 0; i < Results.Count; i++)
            {
                ColumnHeader Header = new ColumnHeader();
                Header.Text = (i + 1).ToString();
                if (Results.Count <= (this.ListView.Width - this.ListView.Columns[0].Width) / 50)
                    Header.Width = (this.ListView.Width - this.ListView.Columns[0].Width) / Results.Count;
                else
                    Header.Width = 50;
                Header.TextAlign = HorizontalAlignment.Center;
                this.ListView.Columns.Add(Header);
            }
        }

        private void SetupBallotInforLabels(List<int> RoundValidBallots,
                                    int InvalidBallots, List<int> RoundExhaustedBallots,
                                    int TotalBallots, List<int> RoundMajority)
        {
            Label Label;
            foreach (int Value in RoundValidBallots)
            {
                Label = new Label();
                Label.Text = Value.ToString();
                Label.Font = new Font("Modern No. 20", 12);
                if (RoundValidBallots.Count <= this.ValidBallotPanel.Width / 50)
                    Label.Size = new Size(this.ValidBallotPanel.Width / RoundValidBallots.Count, this.ValidBallotPanel.Height);
                else
                    Label.Size = new Size(50, this.ValidBallotPanel.Height);
                Label.BackColor = SystemColors.ControlLightLight;
                Label.BorderStyle = BorderStyle.FixedSingle;
                Label.Margin = new Padding(0);
                Label.TextAlign = ContentAlignment.MiddleCenter;
                this.ValidBallotPanel.Controls.Add(Label);
            }

            this.InvalidBallotLabel.Text = InvalidBallots.ToString();
            this.InvalidBallotLabel.BackColor = SystemColors.ControlLightLight;

            foreach (int Value in RoundExhaustedBallots)
            {
                Label = new Label();
                Label.Text = Value.ToString();
                Label.Font = new Font("Modern No. 20", 12);
                if (RoundExhaustedBallots.Count <= this.ExhaustedBallotPanel.Width / 50)
                    Label.Size = new Size(this.ExhaustedBallotPanel.Width / RoundExhaustedBallots.Count, this.ExhaustedBallotPanel.Height);
                else
                    Label.Size = new Size(50, this.ExhaustedBallotPanel.Height);
                Label.BackColor = SystemColors.ControlLightLight;
                Label.Margin = new Padding(0);
                Label.BorderStyle = BorderStyle.FixedSingle;
                Label.TextAlign = ContentAlignment.MiddleCenter;
                this.ExhaustedBallotPanel.Controls.Add(Label);
            }

            this.TotalBallotLabel.Text = TotalBallots.ToString();
            this.TotalBallotLabel.BackColor = SystemColors.ControlLightLight;

            foreach(int Value in RoundMajority)
            {
                Label = new Label();
                Label.Text = Value.ToString();
                Label.Font = new Font("Modern No. 20", 12);
                if (RoundMajority.Count <= this.MajorityPanel.Width / 50)
                    Label.Size = new Size(this.MajorityPanel.Width / RoundMajority.Count, this.MajorityPanel.Height);
                else
                    Label.Size = new Size(50, this.MajorityPanel.Height);
                Label.BackColor = SystemColors.ControlLightLight;
                Label.Margin = new Padding(0);
                Label.BorderStyle = BorderStyle.FixedSingle;
                Label.TextAlign = ContentAlignment.MiddleCenter;
                this.MajorityPanel.Controls.Add(Label);
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            ((PageResultContainer)this.MdiParent).Close();
        }
    }
}
