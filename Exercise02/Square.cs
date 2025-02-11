﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02;

public class Square : Rectangle
{
    public Square(double width) : base(height: width, width: width) { }

    public override double Height
    {
        set
        {
            height = value;
            width = value;
        }
    }

    public override double Width 
    { 
        set { height = value; }
    }

    public override double Area => Height * Width;

}
