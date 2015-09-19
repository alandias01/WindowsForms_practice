using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsForms_practice.MVCPrac
{
    class ModelB:IModel
    {
        public int val { get; set; }

        public void SetValue(int x) { val = x; onChange(); }

        public int GetA() { return val; }

        public int GetB() { return val * 2; }
        public event ValChanged change;
        public void onChange() { change(); }
    }
}
