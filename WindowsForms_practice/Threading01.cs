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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var ds = new DAL().GetData();

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables[0].TableName;
            new Thread(() => thread2(ds)).Start();
        }

        private void thread2(DataSet ds2)
        {
            this.BeginInvoke(new Action(() =>
            {
                textBox1.Text = ds2.Tables[0].Rows.Count.ToString();
            }));

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex] as DataGridViewRow;
            textBox1.Text = row.Cells["d_id"].Value.ToString();
        }

    }


     
    public class DAL
    {
        public DataSet GetData()
        {
            DataSet ds = new DataSet();
            string cstr = "Server=localhost;Database=testing;Uid=root;Pwd=nsxr;";
            using (MySqlConnection conn = new MySqlConnection(cstr))
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select * from dept", conn);
                da.Fill(ds);
            }

            return ds;
        }
    }
}
