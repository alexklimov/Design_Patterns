using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype_example
{
    interface IFigure
    {
        IFigure Clone();
        void GetInfo();
    }
}
