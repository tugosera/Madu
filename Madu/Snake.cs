﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madu
{
    class Snake: Figure
    {
        public Snake(Point tail, int lenght, Direction direction)
        {
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(1, direction);
                plist.Add(p);
            }
        }
    }
}
