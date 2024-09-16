using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Madu
{
    internal class Snake: Figure
    {

        Direction direction;
        public int gool = 0;

        public Snake(Point tail, int lenght, Direction direction)
        {
            plist = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                plist.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = plist.First();
            plist.Remove(tail);
            Point head = getNextPoint();
            plist.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point getNextPoint()
        {
            Point head = plist.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        internal bool  IsHitTail()
        {
            var head = plist.Last();
            for(int i = 0; i < plist.Count - 2; i++)
            {
                if (head.IsHit(plist[i])) 
                    return true;
            }
            return false;
        }

        public void HandlKey(ConsoleKey Key)
        {
            if (Key == ConsoleKey.LeftArrow)
                direction = Direction.Left;
            else if (Key == ConsoleKey.RightArrow)
                direction = Direction.Right;
            else if (Key == ConsoleKey.UpArrow)
                direction = Direction.Up;
            else if (Key == ConsoleKey.DownArrow)
                direction = Direction.Down;
        }

        internal bool Eat(Point food)
        {
            Point Head = getNextPoint();
            if (Head.IsHit(food))
            {
                food.sym = Head.sym;
                plist.Add(food);
                gool += 1;
                return true;
            }
            else
                return false;
        }

    }
}
