using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsForms_practice.MVCPrac
{
    class ControllerA:IController
    {
        IModel Model;
        public ControllerA(IModel M) { this.Model = M; }


        public void Increase() { Model.SetValue(++Model.val); }

        public void Decrease() { Model.SetValue(--Model.val); }

        public void SetTextBoxValue(int x) { Model.SetValue(x); }

        public int ShowA() { return Model.GetA(); }

        public int ShowB() { return Model.GetB(); }
    }
}
