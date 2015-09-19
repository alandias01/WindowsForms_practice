using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace WindowsForms_practice.MVCPrac
{
    public delegate void ValChanged();
    public interface IModel
    {
        event ValChanged change;
        int val { get; set; }
        void SetValue(int x);
        int GetA();
        int GetB();
        void onChange();
    }
}
