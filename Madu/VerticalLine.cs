﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madu
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yBot, int yTop, int x, char sym)
        {
            Color slateBlue = Color.FromName("SlateBlue");
            plist = new List<Point>();
            for (int y = yBot; y <= yTop; y++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);
            }
        }
    }
}
