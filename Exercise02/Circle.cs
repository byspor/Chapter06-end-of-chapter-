using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02;

public class Circle : Shape
{

    public Circle() { }

    public Circle(double radius)
    {
        Height = radius * 2;
        Width = radius * 2;
    }

    public double radius
    {
        get => Height / 2;
        set
        {
            Height = value * 2;
            Width = value * 2;
        }

    }




    public override double Area => Math.PI * radius * radius;

}

