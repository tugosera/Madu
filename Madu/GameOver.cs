using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Madu
{
    public class GameOver
    {

        public void GG(Snake snake, Stopwatch sw)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            horizontalLine upline = new horizontalLine(10, 60, 13,'/');
            horizontalLine Downline = new horizontalLine(10, 60, 23, '/');

            upline.Drow();
            Downline.Drow();
            Console.SetCursorPosition(30, 15);
            Console.WriteLine("GAME OVER");
            
            Console.SetCursorPosition(30, 19);
            Console.WriteLine("Time spent  - {0}", sw);
            Console.SetCursorPosition(30, 17);
            Console.Write("Score: {0}", snake.gool);
            Console.ReadLine();
        }

    }
}
