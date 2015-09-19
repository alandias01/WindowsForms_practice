using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms_practice.MVCTest
{
    public partial class MVCTestForm : Form
    {
        ITradeModel ITM;
        ITradeController ITC;

        
        //If you initialize without args, it picks a default model and controller
        public MVCTestForm()
        {
            ITM = new TradeModelA();
            ITC = new TradeControllerA(ITM);
            ITM.TradeAdded += Update;
            InitializeComponent();

        }

        //Here you decide how Form is controlled
        public MVCTestForm(ITradeController ITC,ITradeModel ITM)
        {
            this.ITC=ITC;
            this.ITM=ITM;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Price=0;
            try
            {
                Price = Convert.ToDouble(textBoxPrice.Text);
                TradeObject TO = new TradeObject(textBoxCusip.Text, textBoxQuantity.Text, Convert.ToDouble(Price));
                ITC.AddTrade(TO);
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Enter appropriate Price " + ex.Message); 
            }
            
        }

        public void Update(object s, EventArgs e)
        {
            dgv1.DataSource = null;
            dgv1.DataSource = ITC.GetTrades();
 
        }

        private void dgv1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                /*
                ContextMenu CM = new ContextMenu();
                MenuItem MIPeach = new MenuItem("Peach");                
                MenuItem MIYellow = new MenuItem("Yellow");
                int i = dgv1.HitTest(e.X, e.Y).RowIndex;


                MIPeach.Click += (s, t) => 
                {
                    dgv1.Rows[i].DefaultCellStyle.BackColor = Color.PeachPuff;                    
                };

                MIYellow.Click += (s, t) =>
                {
                    dgv1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                };

                CM.MenuItems.AddRange(new MenuItem[] { MIPeach, MIYellow });
                                
                CM.Show(dgv1, e.Location);
                */

                ContextMenuStrip CMS = new ContextMenuStrip();
                CMS.Items.Add(new ToolStripMenuItem("Add"));
                CMS.Show(dgv1, e.Location);




            }
        }






    }
}
