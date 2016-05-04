using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype_example
{
    class Program
    {
        static void Main(string[] args)
        {
        IFigure figure = new Rectangle(30,40);
        IFigure clonedFigure = figure.Clone();
        figure.GetInfo();
        clonedFigure.GetInfo();
 
        figure = new Circle(30);
        clonedFigure=figure.Clone();
        figure.GetInfo();
        clonedFigure.GetInfo();

        Console.Read();
        }
    }
}
