using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms_practice
{
    public partial class DragDropFile : Form
    {
        public DragDropFile()
        {
            InitializeComponent();            
            
        }

        private void DragDropFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void DragDropFile_DragDrop(object sender, DragEventArgs e)
        {
            string[] Files = (string[])e.Data.GetData(DataFormats.FileDrop);
            dataGridView1.DataSource = (from i in Files select new { Name = i.ToString() }).ToList();            
        }




    }
}
