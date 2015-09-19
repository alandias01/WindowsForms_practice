using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsForms_practice.MVCPrac
{
    public partial class MVC01 : Form
    {        
        public MVC01()
        {
            InitializeComponent();
        }

        private void buttonViewA_Click(object sender, EventArgs e)
        {            
            IModel M = new ModelA();
            GenericView view = new GenericView(new ControllerA(M), M);
            view.SetLabels("Temperature", "Temp", "Temp2", "Enter Temp");
            view.Show();
        }
    }
}
