using System;
using System.Collections;
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
    public partial class AddVoteSystem : Form
    {
        ArrayList listCandidate;
        InputCandidate inputCandidateWindow;
        List<AVote> listVote;

        public AddVoteSystem(ArrayList listCandidate,InputCandidate inputCandidateWindow)
        {
            listVote = new List<AVote>();
            this.inputCandidateWindow = inputCandidateWindow;
            this.listCandidate = listCandidate;
            InitializeComponent();
        }

        private void AddVoteSystem_Load(object sender, EventArgs e)
        {
            //Hide old window
            this.inputCandidateWindow.Hide();
            //Add candidate to listBox and tagged them with a number.
            for (int i =0; i < this.listCandidate.Count; i++)
            {
                CandidateListBox.Items.Add( i+1+". " + this.listCandidate[i]);
            }
        }

        private void CreateVoteButton_Click(object sender, EventArgs e)
        {
            VoteCandidate newVote = new VoteCandidate(AVote.ConvertFromArrayList<string>(this.listCandidate), 
                                                        this.listVote, this);
            newVote.Show();
            this.Hide();
        }

        public void finishAddedAVote()
        {
            MessageBox.Show("A vote has been added.", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Show();
        }

        private void EndVoteButton_Click(object sender, EventArgs e)
        {
            
            this.inputCandidateWindow.setUpDataWindow.Show();
            this.inputCandidateWindow.setUpDataWindow.EnableShowResult();
            this.inputCandidateWindow.setUpDataWindow.AVoteList = this.listVote;
        }
    }
}
