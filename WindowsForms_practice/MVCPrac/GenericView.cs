using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsForms_practice.MVCPrac
{
    public partial class GenericView : Form
    {
        IController controller; IModel Model;

        public GenericView(IController c, IModel M)
        {
            this.controller = c; this.Model = M;
            M.change += Update1;
            InitializeComponent();
            
        }

        public void Update1() 
        { 
            label1.Text = controller.ShowA().ToString();
            label2.Text = controller.ShowB().ToString();
        }

        private void button1_Click(object sender, EventArgs e) { controller.Increase(); }

        private void button2_Click(object sender, EventArgs e) { controller.Decrease(); }

        private void button3_Click(object sender, EventArgs e)
        {
            controller.SetTextBoxValue(Convert.ToInt16(textBoxInput.Text));
        }

        public void SetLabels(string labelMain, string labelShow1, string labelShow2, string labelTextbox)
        {
            this.labelMain.Text = labelMain;
            this.labelShow1.Text = labelShow1;
            this.labelShow2.Text = labelShow2;
            this.labelTextbox.Text = labelTextbox;
        }
    }
}
