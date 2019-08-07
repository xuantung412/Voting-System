using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Agile_Assignment_3
{
    public partial class RoundResultPage : Form
    {
        Dictionary<string, int> Results;
        /*List<Label> NameLabels = new List<Label>(),
                    PreferenceLabels = new List<Label>();*/
        RoundResultPage PreviousPage, NextPage;
        VotingInfoTable Table;
        List<AVote> dataResult; //Use AVote to store data each round.

        public RoundResultPage(Dictionary<string, int> Results, int ValidBallots, int InvalidBallots,
                                int ExhaustedBallots, int TotalBallots, int Majority, int Round, List<AVote> roundVoteResult)
        {
            InitializeComponent();
            this.dataResult = roundVoteResult;
            this.Results = Results;
            this.TitleLabel.Text = "Round " + Round.ToString();
            this.SetupResultTable(Results);
            this.SetupInfoLabels(ValidBallots, InvalidBallots, ExhaustedBallots, TotalBallots, Majority);
            this.SetupChart(InvalidBallots, ExhaustedBallots, TotalBallots);
        }

        private void SetupPageSwitchingButtons()
        {
            if (this.PreviousPage == null)
                this.PreviousPageSwitch.Hide();
            else
                this.PreviousPageSwitch.Show();
            if (this.NextPage == null)
                this.NextPageSwitch.Hide();
            else
                this.NextPageSwitch.Show();
        }

        public void SwitchToNextPage()
        {
            if(this.NextPage != null)
                this.NextPageSwitch_Click(this.NextPageSwitch, new EventArgs());
        }
        private void SetupResultTable(Dictionary<string, int> Results)
        {
        /*Label Name, Preference;
            AVote roundResult = new AVote(new ArrayList(), new ArrayList());
            foreach (KeyValuePair<string, int> Result in this.Results)
            {
                Name = new Label();
                Preference = new Label();
                Name.Text = Result.Key;

                Preference.Text = (Result.Value > 0? Result.Value.ToString() : "P");

                Name.Font = new Font("Modern No. 20", 12);
                Preference.Font = Name.Font;
                Name.Margin = new Padding(0);
                Preference.Margin = new Padding(0);
                Name.Size = new Size(this.NameLabelPanel.Width / Results.Count, this.NameLabelPanel.Height);
                Preference.Size = new Size(this.PreferenceLabelPanel.Width / Results.Count, this.PreferenceLabelPanel.Height);
                this.NameLabelPanel.Controls.Add(Name);
                this.PreferenceLabelPanel.Controls.Add(Preference);
            }*/
            List<string> Candidates = new List<string>();
            List<int> Preferences = new List<int>();
            AVote roundResult = new AVote(new ArrayList(), new ArrayList());
            foreach(KeyValuePair<string,int> Result in Results)
            {
                Candidates.Add(Result.Key);
                roundResult.candidateList.Add(Result.Key+"");  //Add candidate
                Preferences.Add(Result.Value);
                roundResult.voteCandidate.Add(Result.Value +""); //Add vote
            }
            this.TablePanel.Controls.Add(this.Table = new VotingInfoTable(Candidates, Preferences, true));
            this.dataResult.Add(roundResult);
        }

        private void SetupInfoLabels(int ValidBallots, int InvalidBallots, 
                                        int ExhaustedBallots, int TotalBallots, int Majority)
        {
            this.ValidBallotLabel.Text = ValidBallots.ToString();
            this.InvalidBallotLabel.Text = InvalidBallots.ToString();
            this.ExhaustedBallotLabel.Text = ExhaustedBallots.ToString();
            this.TotalBallotLabel.Text = TotalBallots.ToString();
            this.MajorityLabel.Text = Majority.ToString();
        }

        private void SetupChart(int InvalidBallots, int ExhaustedBallots, int TotalBallots)
        {
            ChartArea PieChartArea = new ChartArea("PieChartArea");
            Series PieChart = new Series();
            Legend PieChartLegend = new Legend();
            DataPoint point;
            PieChart.ChartArea = "PieChartArea";
            PieChart.ChartType = SeriesChartType.Pie;
            PieChartArea.BackColor = Color.Transparent;
            PieChartLegend.BackColor = Color.Transparent;
            PieChartLegend.IsDockedInsideChartArea = false;
            PieChartLegend.DockedToChartArea = "PieChartArea";
            point = new DataPoint(0, InvalidBallots / (double)TotalBallots);
            point.LegendText = "Invalid Ballots";
            if(InvalidBallots > 0)
                point.Label = "#VAL{P}";
            PieChart.Points.Add(point);
            point = new DataPoint(0, ExhaustedBallots / (double)TotalBallots);
            point.LegendText = "Exhausted Ballots";
            if(ExhaustedBallots > 0)
                point.Label = "#VAL{P}";
            PieChart.Points.Add(point);
            foreach(KeyValuePair<string, int> Result in this.Results)
            {
                point = new DataPoint(0, Result.Value / (double)TotalBallots);
                point.LegendText = Result.Key;
                if(Result.Value > 0)
                    point.Label = "#VAL{P}";
                PieChart.Points.Add(point);
            }
            this.Chart.ChartAreas.Add(PieChartArea);
            this.Chart.Series.Add(PieChart);
            this.Chart.Legends.Add(PieChartLegend);
        }

        public Dictionary<string, int> GetRoundResults()
        {
            return this.Results;
        }

        public void SetNextPage(RoundResultPage page)
        {
            this.NextPage = page;
            this.SetupPageSwitchingButtons();
        }

        public void SetPreviousPage(RoundResultPage page)
        {
            this.PreviousPage = page;
            this.SetupPageSwitchingButtons();
        }

        public RoundResultPage GetPreviousPage()
        {
            return this.PreviousPage;
        }

        public RoundResultPage GetNextPage()
        {
            return this.NextPage;
        }

        private void TitleLabel_TextChanged(object sender, EventArgs e)
        {
            this.TitleLabel.Location = new Point((this.Width - this.TitleLabel.PreferredSize.Width) / 2, this.TitleLabel.Location.Y);
        }

        private void PreviousPageSwitch_Click(object sender, EventArgs e)
        {
            this.PreviousPage.Show();
            this.Hide();
        }

        private void NextPageSwitch_Click(object sender, EventArgs e)
        {
            this.NextPage.Show();
            this.Hide();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            ((PageResultContainer)this.MdiParent).Close();
        }
    }
}
