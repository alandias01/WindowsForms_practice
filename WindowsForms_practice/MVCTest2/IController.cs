using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsForms_practice.MVCTest2
{
    public interface IController<T,U>
    {
        List<T> GetTopList();
        List<U> GetBottomList();
    }
}
