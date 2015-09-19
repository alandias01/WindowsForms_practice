using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using MySql.Data.MySqlClient;


namespace WindowsForms_practice
{
    /* Create random numbers in second thread
     * Main thread displays random number
     */


    public partial class Form1 : Form
    {
        RateClass r;
        public Form1()
        {
            InitializeComponent();
            r = new RateClass();
            new Thread(() => r.Start()).Start();

            System.Timers.Timer t = new System.Timers.Timer(500);
            t.Elapsed += (s, e) => { this.BeginInvoke(new Action(() => this.textBox1.Text = r.Rate.ToString() ) ); };
            t.Start();
        }






    }

    public class RateClass
    {
        public int Rate { get; set; }
        
        public void Start()
        {
            
            System.Timers.Timer tm = new System.Timers.Timer(300);
            Rate = 3;
            tm.Elapsed += (s,e)=>GenNum(this);
            
            tm.Start();
        }

        public void GenNum(RateClass r) { Random num = new Random(); r.Rate = num.Next(100);  }






    }


   
}
