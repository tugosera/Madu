using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madu
{
    public class MainClass
    {
        static void Main(string[] args)
        {

            Console.SetWindowSize(80, 25);

            horizontalLine upline = new horizontalLine(0,78, 0, '-');
            horizontalLine downline = new horizontalLine(0, 78, 24, '-');
            VerticalLine leftline = new VerticalLine(0, 24, 0, '|');
            VerticalLine rightline = new VerticalLine(0, 24, 78, '|');
            upline.Drow();
            downline.Drow();
            leftline.Drow();
            rightline.Drow();

            Point p = new Point(23, 7, '*');
            Snake snake = new Snake(p, 5, Direction.Right);
            snake.Drow();

            while(true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.LeftArrow) {
                }
            }








            Console.ReadLine();

            /*List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }     */


        }
    }
}
