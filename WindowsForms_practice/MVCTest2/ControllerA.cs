using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace WindowsForms_practice.MVCTest2
{
    class ControllerA : IController<Employee, Person>
    {
        List<Employee> Emp;
        List<Person> People;

        public ControllerA(List<Employee> Emp, List<Person> People)
        {
            this.Emp = Emp;
            this.People = People;
        }

        public List<Employee> GetTopList()
        {
            return Emp;
        }

        public List<Person> GetBottomList()
        {
            return People;
        }


    }
}
