using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Agile_Assignment_3
{
    public partial class BarGraph : Form
    {
        private ArrayList values;
        private ArrayList candidate;

        public BarGraph()
        {
            InitializeComponent();
        }

        public BarGraph(ArrayList valuesInNumber, ArrayList candidate)
        {
            values = new ArrayList();
            this.candidate = new ArrayList();

            int total = 0;
            for(int i=0; i < valuesInNumber.Count; i++)
            {
                total += Convert.ToInt32((valuesInNumber[i]));
            }

            //transform each number in valueArray into percentage
            for (int i = 0; i < valuesInNumber.Count; i++)
            {
                values.Add(Convert.ToInt32((valuesInNumber[i]))*100 / total);
                this.candidate.Add(candidate[i]);
            }

        }

        private void BarGraph_Load(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        // New OnPaint method
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graph = e.Graphics;

            // The margins are to give some space rather than drawing right on the edge of the component.
            int leftMargin = 30;
            int rightMargin = 40;
            int topMargin = 30;
            int bottomMargin = 40;

            // This are the maximum practical height and width, after we allow for some margins to make it neat.
            // Double is used here as 1 * 100 is very different from 1.1 * 100, even if we convert to an integer at the end of the process.
            double maxWidth = this.Width - leftMargin - rightMargin;
            double maxHeight = this.Height - topMargin - bottomMargin - 30;

            graph.Clear(Color.WhiteSmoke);

            // Created this as a method so we can reuse it in the print functions.
            this.generateGraph(graph, leftMargin, topMargin, maxHeight, maxWidth);

            // Just to repaint any additional features.
            base.OnPaint(e);
        }

        // Method that does the real work of drawing the graph.
        private void generateGraph(Graphics g, int leftMargin, int topMargin, double maxHeight, double maxWidth)
        {
            int range = 100; // This could normally be gained by looking at the range of values and picking the largest.

            // Maximum width of each individual column - we need room to fit them all. 
            double columnWidth = (maxWidth / values.Count);

            //Create brokenLind for graph.
            Pen brokenLinePen = new Pen(Brushes.Black);
            brokenLinePen.DashStyle = DashStyle.Custom;
            brokenLinePen.DashPattern = new float[] { 2,2 };

            //Drow vertical line.
            g.DrawLine(new Pen(Color.Black, 3), new Point(20, 30), new Point(20, 230));
            g.DrawLine(new Pen(Color.Black, 1), new Point(20, 30), new Point(15, 30));
            g.DrawLine(brokenLinePen, new Point(20, 30), new Point(260, 30));
        
            g.DrawLine(new Pen(Color.Black, 1), new Point(20, 80), new Point(15, 80));
            g.DrawLine(brokenLinePen, new Point(20, 80), new Point(260, 80));

            g.DrawLine(new Pen(Color.Black, 1), new Point(20, 130), new Point(15, 130));
            g.DrawLine(brokenLinePen, new Point(20, 130), new Point(260, 130));

            g.DrawLine(new Pen(Color.Black, 1), new Point(20, 180), new Point(15, 180));
            g.DrawLine(brokenLinePen, new Point(20, 180), new Point(260, 180));

            g.DrawLine(new Pen(Color.Black, 3), new Point(20, 230), new Point(15, 230));
            g.DrawLine(new Pen(Color.Black,3), new Point(20, 230), new Point(260, 230));

            //Draw text to display information.
            g.DrawString("0%", new Font("Arial",7), Brushes.Red, 2, 220);
            g.DrawString("25%", new Font("Arial", 7), Brushes.Red, 0, 169);
            g.DrawString("50%", new Font("Arial", 7), Brushes.Red, 0, 119);
            g.DrawString("75%", new Font("Arial", 7), Brushes.Red, 0, 69);
            g.DrawString("100%", new Font("Arial", 7), Brushes.Red, 0, 17);



            // Loop through the values we need to display
            for (int columnNumber = 0; columnNumber < values.Count; columnNumber++)
            {
                // Here we could set different colours for different columns, which is
                // why I'm setting them in the loop.
                Pen currentPen = new Pen(Color.Brown);
                Brush currentBrush = new SolidBrush(Color.BurlyWood);

                // Calculate teh height of this particular column.
                int columnHeight = (int)((maxHeight / range) * Convert.ToInt32(values[columnNumber]));

                // Work out the top left corner of the column.
                int y = (int)(topMargin + maxHeight - columnHeight);
                int x = (int)(leftMargin + (columnWidth * columnNumber));

                // Draw a filled rectangle for the column
                g.FillRectangle(currentBrush, x, y, (int)columnWidth, columnHeight);

                // Draw a border around it to make it look pretty
                g.DrawRectangle(currentPen, x, y, (int)columnWidth, columnHeight);

                //Draw text to display information for each
                g.DrawString(values[columnNumber]+"",  new Font("Arial", 7), Brushes.Blue,(240/ values.Count)/2-10+ x,y-10);

                //Draw text to display candidate
                g.DrawString(candidate[columnNumber] + "", new Font("Arial", 7), Brushes.BlueViolet, (240 / values.Count) / 2 - 10 + x, 240);

            }
        }

        // Makes resizing work by forcing a full redraw each time.

        private void PrintButton_Click(object sender, EventArgs e)
        {
            // Create a new page
            PrintDocument pd = new PrintDocument();
            // Set the event to handle it.
            pd.PrintPage += new PrintPageEventHandler(this.PrintPageEvent);
            // Print the page.
            pd.Print();
        }


        // This is where the work of printing each individual page occurs.
        private void PrintPageEvent(object sender, PrintPageEventArgs ev)
        {
            Graphics g = ev.Graphics;

            // Work out the margins.
            int marginLeft = ev.PageSettings.Margins.Left;
            int marginRight = ev.PageSettings.Margins.Right;
            int marginTop = ev.PageSettings.Margins.Top;
            int marginBottom = ev.PageSettings.Margins.Bottom;

            // Work out the usable height and width
            double maxHeight = ev.PageSettings.PrintableArea.Height - marginTop - marginBottom;
            double maxWidth = ev.PageSettings.PrintableArea.Width - marginLeft - marginRight;

            // Draw the graph
            this.generateGraph(g, marginLeft, marginTop, maxHeight, maxWidth);
        }
        // Called when the print button is used.
        private void graph_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }



}
