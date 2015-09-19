using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsForms_practice.MVCPrac
{
    public interface IController
    {
        
        void Increase();
        void Decrease();
        void SetTextBoxValue(int x);
        int ShowA();
        int ShowB();
    }
}
