using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms_practice.MVCTest3
{
    class Controller : IController
    {
        readonly IModel _model;

        public Controller(IModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException("model");
            }
            _model = model;
        }

        public void ShowProjectView(Form owner)
        {
            ExtraFormView view = new ExtraFormView(this, _model);
            view.Owner = owner;
            view.Show();
            
        }

        public void Update(Project project)
        {
            _model.UpdateProject(project);
        }
    }
}
