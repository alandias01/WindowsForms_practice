using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsForms_practice.Thread1
{
    public partial class ThreadView : Form
    {
        List<WordsObject> WO = new List<WordsObject>();
        WordsDA WDA = new WordsDA();

        public ThreadView()
        {
            InitializeComponent();
                        
            BackgroundWorker BW = new BackgroundWorker();
            BW.DoWork += (s, e) => 
            { 
                //WDA.LoadAll(WO);
                int j;
                for (int i = 0; i < 500; i++)
                {
                    Thread.Sleep(15);
                    j = (100 * i) / 500;
                    BW.ReportProgress(j);
                }
            };

            BW.ProgressChanged += (s, e) => { progressBar1.Value = e.ProgressPercentage; };

            BW.RunWorkerCompleted += (s, e) => { DGVWords.DataSource = WO; };
            
            BW.WorkerReportsProgress = true;
            BW.RunWorkerAsync();
            
            
        }
    }
}
