using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madu
{
    internal class Walls
    {
        List<Figure> WaLLlist;

        public Walls(int mapWidth, int mapHeight)
        {
            WaLLlist = new List<Figure>();


            horizontalLine upline = new horizontalLine(0, mapWidth - 2, 2, '-');
            horizontalLine downline = new horizontalLine(0, mapWidth - 2, mapHeight - 1, '-');
            VerticalLine leftline = new VerticalLine(2, mapHeight - 1, 0, '|');
            VerticalLine rightline = new VerticalLine(2, mapHeight - 1, mapWidth - 2, '|');
            WaLLlist.Add(upline);
            WaLLlist.Add(downline);
            WaLLlist.Add(leftline);
            WaLLlist.Add(rightline);
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in WaLLlist)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in WaLLlist)
            {
                wall.Drow();
            }
        }


    }
}
