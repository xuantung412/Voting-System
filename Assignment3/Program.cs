using Agile_Assignment_3;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agile_Assignment_3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            /*Application.SetCompatibleTextRenderingDefault(false);
            //For testing purpose
            
            ArrayList vote = new ArrayList();
            vote.Add(1);
            vote.Add(2);
            vote.Add(6);
            vote.Add(7);
            vote.Add(4);
            ArrayList candidate = new ArrayList();
            candidate.Add("Tom");
            candidate.Add("Harris");
            candidate.Add("Editon");
            candidate.Add("Hilton");
            candidate.Add("Trumph");


            Application.Run(new BarGraph(vote, candidate));*/
            Application.Run(new SetUpData());

        }
    }
}
