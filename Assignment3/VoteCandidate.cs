using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agile_Assignment_3
{
    public partial class VoteCandidate : Form
    {
        List<string> Candidates;
        List<AVote> Ballots;
        AddVoteSystem AddVoteForm;
        VotingInfoTable Table;
        public VoteCandidate(List<string> Candidates, List<AVote> Ballots, AddVoteSystem AddVoteForm)
        {
            InitializeComponent();
            this.Candidates = Candidates;
            this.Ballots = Ballots;
            this.AddVoteForm = AddVoteForm;
            this.TablePanel.Controls.Add(this.Table = new VotingInfoTable(Candidates, null, false));
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Ballots.Add(new AVote(AVote.ConvertFromList<string>(this.Candidates),
                                        AVote.ConvertFromList<int>(this.Table.GetPreferenceInput())));
            this.AddVoteForm.finishAddedAVote();
            this.AddVoteForm.Show();
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.AddVoteForm.Show();
            this.Close();
        }
    }
 }
