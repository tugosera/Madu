using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Madu
{
    internal class GameOver
    {
        public void GG()
        {
            horizontalLine upline = new horizontalLine(20, 40, 15,'/');
            VerticalLine Leftline = new VerticalLine(16, 26, 20, '/');
            VerticalLine Rightline = new VerticalLine(16, 26, 40, '/');
            Console.SetCursorPosition(30, 15);
            Console.WriteLine("GAME OVER");
            Console.SetCursorPosition(30, 17);
            Console.Write("Score: {0}", snake.gool);
            Console.SetCursorPosition(30, 19);
            Console.WriteLine("Time spent  - {0}");

        }

    }
}
