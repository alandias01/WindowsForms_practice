using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsForms_practice.MVCTest2
{
    

    public partial class ExtraForm<T,U> : Form
    {
        IController<T,U> Controller;
        

        public ExtraForm(IController<T,U> C)
        {               
            InitializeComponent();
            this.Controller = C;
            DGVTop.DataSource = Controller.GetTopList();
            DGVBottom.DataSource = Controller.GetBottomList();
        }
    }
}
