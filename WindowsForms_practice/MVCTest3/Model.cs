using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsForms_practice.MVCTest3
{
    class Model : IModel
    {
        public IEnumerable<Project> Projects { get; set; }        

        public event EventHandler<ProjectEventArgs> ProjectUpdated;

        public Model()
        {
            Projects = new List<Project>() { new Project { Name = "Proj01", Actual = 1, Estimate = 2, ID = 3 }, new Project { Name = "Proj02", Actual = 4, Estimate = 5, ID = 6 } };
        }

        private void RaiseProjectUpdated(Project project)
        {
            ProjectUpdated(this, new ProjectEventArgs(project)); 
        }


        public void UpdateProject(Project project)
        {
            Project SelectedProj = Projects.Where(p => p.ID == project.ID).FirstOrDefault() as Project;
            SelectedProj.Name = project.Name;
            SelectedProj.Estimate = project.Estimate;
            SelectedProj.Actual = project.Actual;
            RaiseProjectUpdated(SelectedProj);
        }
    }

    public class ProjectEventArgs : EventArgs
    {
        public Project Project { get; set; }
        public ProjectEventArgs(Project project)
        {
            Project = project;
        }
    }
}
