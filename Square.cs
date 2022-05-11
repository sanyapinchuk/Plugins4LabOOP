﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figures
{
    public class Square :Rect
    {
        
        public Square(Point point, int width, Color color) : base(point, width, width,color)
        {
            position = point;
            this.Width = this.Height = width;
        }
        public Square(Point first, Point second, Color color) : base(first,second, color)
        {
            position = first;
            Width = second.X - first.X;
            Height = Width;
            
        }
    }
}
