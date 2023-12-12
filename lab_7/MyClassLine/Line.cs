using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLine;

internal class Line
{
    private Point pStart;
    private Point pEnd;

    public Line(Point pStart, Point pEnd)
    {
         this.pStart = pStart;
         this.pEnd = pEnd;
    }
    public Line()
    { }

    public void Show()
    {
        Console.WriteLine($"Отрезок с координатами: ({pStart.ToString()}) - ({pEnd.ToString()})");
    }

    public double DlinL()
    {
        return pStart.Dlina(pEnd);
    }
}
