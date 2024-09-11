using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madu
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yBot, int yTop, int x, char sym)
        {
            plist = new List<Point>();
            for (int y = yBot; y <= yTop; y++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);
            }
        }
    }
}
