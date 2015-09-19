using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms_practice.MVCTest2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            List<Employee> Emp = new List<Employee> { new Employee(true, "alan", 30) };
            List<Person> People = new List<Person> { new Person(true, "alan", 30) };
            ExtraForm<Employee, Person> E = new ExtraForm<Employee, Person>(new ControllerA(Emp, People));
            E.Show();

        }
    }


    


    public class Employee
    {
        public bool isEmployee { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Employee(bool i, string n, int a) { isEmployee = i; Name = n; Age = a; }
    }

    public class Person
    {
        public bool isPerson { get; set; }
        public string Namea { get; set; }
        public int Agea { get; set; }

        public Person(bool i, string n, int a) { isPerson = i; Namea = n; Agea = a; }
    }
}
