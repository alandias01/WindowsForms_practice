using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsForms_practice.MVCTest3
{
    public interface IModel
    {
        IEnumerable<Project> Projects { get; set; }
        event EventHandler<ProjectEventArgs> ProjectUpdated;
        void UpdateProject(Project project);
    }
}
