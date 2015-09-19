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
    public partial class ExtraFormView : Form
    {
        readonly IModel _model;
        readonly IController _controller = null;

        public ExtraFormView(IController controller, IModel model)
        {            
            InitializeComponent();
            _controller = controller;
            _model = model;

            _model.ProjectUpdated += _model_ProjectUpdated;
            comboBox1.DataSource = _model.Projects;
            comboBox1.DisplayMember = "Name";
        }

        private void UpdateDetails(Project project)
        {
            textBox1.Text = project.Estimate.ToString();
            textBox2.Text = project.Actual.ToString(); 
        }

        void _model_ProjectUpdated(object sender, ProjectEventArgs e)
        {            
            Project p = e.Project;
            textBox1.Text = p.Estimate.ToString();
            textBox2.Text = p.Actual.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Project p = comboBox1.SelectedItem as Project;
            _controller.Update(p);            
        }
    }
}
