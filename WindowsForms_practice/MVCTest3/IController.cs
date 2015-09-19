using System;
namespace WindowsForms_practice.MVCTest3
{
    public interface IController
    {
        void ShowProjectView(System.Windows.Forms.Form owner);
        void Update(Project project);
    }
}
