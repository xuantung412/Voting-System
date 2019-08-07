using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agile_Assignment_3
{
    public partial class SetUpData : Form
    {

        public List<AVote> AVoteList;
        public SetUpData()
        {
            AVoteList = new List<AVote>();
            InitializeComponent();
        }

        private void ManuallyButtonButton_Click(object sender, EventArgs e)
        {
            InputCandidate a = new InputCandidate(this);
            a.Show();
        }

        private void ImportCSVButton_Click(object sender, EventArgs e)
        {
            String filename = "Default.csv";
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filename = dialog.FileName;         //Get path and file name
            }

            if (File.Exists(filename))              //Prevent non exist file.
            {
                try
                {
                    String st = File.ReadAllText(filename);
                    //Use array to store all data
                    String[] arrayList = st.Split('\n');    //Split the text to multiple line.

                    //Take the first line. Array of candidate's name.
                    String[] arrayCandidate = arrayList[0].Split(',');
                    //Transform an array to arrayList
                    ArrayList candidateList = new ArrayList();
                    for (int i = 0; i < arrayCandidate.Length; i++)
                    {
                        candidateList.Add(arrayCandidate[i].TrimStart(new char[] { '\"' }).TrimEnd(new char[] { '\"', '\r' }));
                    }


                    for (int i = 1; i < arrayList.Length - 1; i++)  //Loop from index 1 to avoid first line(Heading)
                    {
                        String[] dataLine = arrayList[i].Split(',');    //Each line has data(vote for each candidate)
                        ArrayList voteCandidate = new ArrayList();
                        for (int j = 0; j < dataLine.Length; j++)
                        {
                            voteCandidate.Add(dataLine[j].TrimStart(new char[] { '\"' }).TrimEnd(new char[] { '\"', '\r' }));
                        }

                        //Create AVote
                        AVote aVote = new AVote(candidateList, voteCandidate);

                        this.AVoteList.Add(aVote);
                    }
                    //Add title
                    this.listBox1.Items.Add(((AVote)this.AVoteList[0]).showAllCandidate());
                    for (int i = 0; i < this.AVoteList.Count; i++)
                    {
                        this.listBox1.Items.Add(((AVote)this.AVoteList[i]).ToString());
                    }
                    this.ShowResult.Show();
                }
                catch (Exception e1)
                {
                    MessageBox.Show("Can not load file.", "Invalid CSV.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
        }

        private void Export_Click(object sender, EventArgs e)
        {

        }

        private void ShowResult_Click(object sender, EventArgs e)
        {
            List<string> candidates = new List<string>();
            foreach (string candidate in this.AVoteList[0].showAllCandidate().Split(','))
                candidates.Add(candidate);
            PageResultContainer container = new PageResultContainer(candidates, this.AVoteList);
            container.Show();
        }

        public void EnableShowResult()
        {
            this.ShowResult.Show();
        }
    }
}
