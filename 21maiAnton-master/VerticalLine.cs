﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21maiAnton
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yUP, int yDown, int x, char sym)
        {
            pList = new List<Point>();
            for(int y = yUP; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
        
    }
}
