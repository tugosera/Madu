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
            
            Console.SetWindowSize(80, 45);

            Walls walls = new Walls(80, 40);
            walls.Draw();

            Point p = new Point(50, 7, '*');
            Snake snake = new Snake(p, 7, Direction.Left);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(80, 25, '&');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                Console.SetCursorPosition(5, 1);
                Console.Write("Score: {0}", snake.gool);
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandlKey(key.Key);
                }
                Thread.Sleep(70);
                snake.Move();
            }









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
