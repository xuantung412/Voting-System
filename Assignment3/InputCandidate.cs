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
    public partial class InputCandidate : Form
    {
        public SetUpData setUpDataWindow;
        public InputCandidate(SetUpData setUpDataWindow)
        {
            this.setUpDataWindow = setUpDataWindow;
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            String name = this.NameCandidateTextBox.Text;
            Boolean allowAddToListBox = true;
            if (name.Equals(""))
            {
                MessageBox.Show("Please enter candidate's name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allowAddToListBox = false;
            }
            else
            {
                //Check existed candidate in listBox
                for (int i = 0; i < this.CandidateListBox.Items.Count; i++)
                {
                    if (((String)this.CandidateListBox.Items[i]).Equals(name))
                    {
                        MessageBox.Show("Candidate is already in a list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        allowAddToListBox = false;
                    }
                }
            }

            if (allowAddToListBox)
            {
                this.CandidateListBox.Items.Add(name);
                MessageBox.Show("Candidate is added to the list.", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NameCandidateTextBox.Text = "";
            }
        }

        private void InputCandidate_Load(object sender, EventArgs e)
        {
            this.setUpDataWindow.Hide();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItem = new ListBox.SelectedObjectCollection(this.CandidateListBox);
            if (this.CandidateListBox.SelectedIndex != -1)
            {
                for (int i = selectedItem.Count - 1; i >= 0; i--)
                    this.CandidateListBox.Items.Remove(selectedItem[i]);
            }
        }

        public ArrayList getCandidateList()
        {
            ArrayList returnList = new ArrayList();
            for (int i = 0; i < this.CandidateListBox.Items.Count; i++)
            {
                returnList.Add(this.CandidateListBox.Items[i]);
            }
            return returnList;
        }

        private void StartVoteButton_Click(object sender, EventArgs e)
        {
            ArrayList aList = new ArrayList();
            for(int i =0; i < this.CandidateListBox.Items.Count; i++)
            {
                aList.Add(this.CandidateListBox.Items[i]);
            }
            AddVoteSystem newSystem = new AddVoteSystem(aList,this);
            newSystem.Show();
        }
    }
}
