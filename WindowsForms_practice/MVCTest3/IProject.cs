using System;
namespace WindowsForms_practice.MVCTest3
{
    public interface IProject
    {
        double Actual { get; set; }
        double Estimate { get; set; }
        int ID { get; set; }
        string Name { get; set; }
        void Update(IProject project);
    }
}
