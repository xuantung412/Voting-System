using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Agile_Assignment_3
{
    public partial class PageResultContainer : Form
    {
        RoundResultPage HeadPage;
        ResultSummaryPage SummaryPage;
        BallotPapersHandler BPHandler;
        public List<AVote> roundVoteResult;
        List<Bitmap> Pages = new List<Bitmap>();
        PrintDocument PrintDocument = new PrintDocument();
        PrintPreviewDialog PrintPreviewDialog = new PrintPreviewDialog();

        public PageResultContainer(List<string> Candidates, List<AVote> Ballots)
        {
            InitializeComponent();
            PrintPreviewDialog.Document = PrintDocument;
            PrintDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            roundVoteResult = new List<AVote>();
            this.BPHandler = new BallotPapersHandler(Candidates, Ballots);
            this.SetupSummaryPage();
            this.SetupResultPages();
            this.ClientSize = new Size(this.HeadPage.Width + 4, this.HeadPage.Height + this.MenuStrip.Height + 4);
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.HeadPage.Show();
        }

        private void SetupResultPages()
        {
            RoundResultPage PreviousPage = null, Iterator;
            this.HeadPage = new RoundResultPage(this.BPHandler.GetResultsForEachRound()[0],
                                this.BPHandler.GetRoundsValidBallots()[0],
                                this.BPHandler.GetInvalidBallotCount(),
                                this.BPHandler.GetRoundsExhaustedBallots()[0],
                                this.BPHandler.GetTotalBallotCount(),
                                this.BPHandler.GetRoundsMajorities()[0], 1,this.roundVoteResult);
            Iterator = this.HeadPage;
            this.HeadPage.MdiParent = this;
            for(int i = 1; i < this.BPHandler.GetResultsForEachRound().Count; i++)
            {
                PreviousPage = Iterator;
                Iterator = new RoundResultPage(this.BPHandler.GetResultsForEachRound()[i],
                                this.BPHandler.GetRoundsValidBallots()[i],
                                this.BPHandler.GetInvalidBallotCount(),
                                this.BPHandler.GetRoundsExhaustedBallots()[i],
                                this.BPHandler.GetTotalBallotCount(),
                                this.BPHandler.GetRoundsMajorities()[i], i + 1,this.roundVoteResult);
                Iterator.SetPreviousPage(PreviousPage);
                if (PreviousPage != null)
                    PreviousPage.SetNextPage(Iterator);
                Iterator.Top = 0;
                Iterator.Left = 0;
                Iterator.MdiParent = this;
            }
        }

        private void SetupSummaryPage()
        {
            this.SummaryPage = new ResultSummaryPage(this.BPHandler.GetResultsForEachRound(),
                                                        this.BPHandler.GetRoundsValidBallots(),
                                                        this.BPHandler.GetInvalidBallotCount(),
                                                        this.BPHandler.GetRoundsExhaustedBallots(),
                                                        this.BPHandler.GetTotalBallotCount(),
                                                        this.BPHandler.GetRoundsMajorities());
            this.SummaryPage.MdiParent = this;
            this.Top = 0;
            this.Left = 0;
        }

        private void RoundViews_Click(object sender, EventArgs e)
        {
            this.HeadPage.Show();
            this.SummaryPage.Hide();
        }

        private void SummaryView_Click(object sender, EventArgs e)
        {
            this.SummaryPage.Show();
            this.HeadPage.Hide();
        }

        private void PrintAsPDF_Click(object sender, EventArgs e)
        {

        }

        private void exportAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String filename = "Default.csv";    //Default file excel.
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "CSV File (*.csv)|*.csv";
            //Change a bit to solve an errors
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filename = dialog.FileName;     //get path name file name.
                StringBuilder csv = new StringBuilder();
                csv.AppendLine("Round,"+this.roundVoteResult[0].showAllCandidate());    //Append the title for the .csv file.
                for (int i = 0; i < this.roundVoteResult.Count; i++)
                {
                    csv.AppendLine(i+1+ ","+this.roundVoteResult[i].showAllVoteForCandidate());
                }
                //csv.Append(this.roundVoteResult.vote[0].showAllCandidate()+"");
                String csvPath = filename;
                System.IO.File.Delete(csvPath);
                File.AppendAllText(csvPath, csv.ToString());
            }
        }

        private Bitmap PrintPages()
        {
            Graphics g = Page.CreateGraphics();
            Bitmap bmp = new Bitmap(this.HeadPage.Width, this.HeadPage.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X + 10, this.Location.Y + 50, 0, 0, this.Size);
            Page.SwitchToNextPage();
            Page = Page.GetNextPage();
            return bmp;
        }
        private void PrinterPrint_Click(object sender, EventArgs e)
        {
            this.Page = this.HeadPage;
            this.HeadPage.Show();
            this.Location = new Point(this.PrintPreviewDialog.DesktopLocation.X + this.PrintPreviewDialog.Width + 80, this.Location.Y);
            this.PrintPreviewDialog.ShowDialog();
        }
        RoundResultPage Page;
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (Page != null)
            {
                e.Graphics.DrawImage(this.PrintPages(), new Point(0, 0));
            }
            if (Page != null)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
        }

    }
}
