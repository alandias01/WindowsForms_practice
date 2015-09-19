using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms_practice.MVCTest3
{
    public partial class MVCTest3 : Form
    {
        IController _controller;

        public MVCTest3()
        {
            InitializeComponent();
            _controller = new Controller(new Model());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _controller.ShowProjectView(this);
        }
    }
}
