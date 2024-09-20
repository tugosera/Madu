using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;


namespace Madu
{
    public class MainClass
    {

        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            Console.SetWindowSize(80, 45);
            Walls walls = new Walls(80, 40);
            walls.Draw();

            Point p = new Point(50, 7, '*');
            Snake snake = new Snake(p, 7, Direction.Left);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(80, 35, '&');
            Point food = foodCreator.CreateFood();
            food.Draw();

            FoodCreator foodCreatorSpeed = new FoodCreator(80, 35, '#');
            Point foodSpeed = foodCreatorSpeed.CreateFoodSpeed();
            foodSpeed.Draw();

            FoodCreator foodCreatorSlow = new FoodCreator(80, 35, '¤');
            Point foodSlow = foodCreatorSlow.CreateFoodSlow();
            foodSlow.Draw();

            FoodCreator foodCreatorGG = new FoodCreator(80, 35, 'X');
            Point foodGG = foodCreatorGG.CreateFoodGG();
            foodGG.Draw();

            Console.SetCursorPosition(3, 40);
            Console.Write("& - 1 score");
            Console.SetCursorPosition(3, 42);
            Console.Write("# - 1 score and + 10speed");
            Console.SetCursorPosition(3, 44);
            Console.Write("¤ - 1 score and - 10speed");

            while (true)
            {
                Console.SetCursorPosition(5, 1);
                Console.Write("Score: {0}", snake.gool);

                Console.SetCursorPosition(50, 1);
                Console.Write("Time: {0}", sw);

                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    GameOver gameOver = new GameOver();
                    gameOver.GG(snake, sw);
                    break;
                }
                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                if (snake.EatSpeed(foodSpeed))
                {
                    foodSpeed = foodCreatorSpeed.CreateFoodSpeed();
                    foodSpeed.Draw();
                }
                if (snake.EatSlow(foodSlow))
                {
                    foodSlow = foodCreatorSlow.CreateFoodSlow();
                    foodSlow.Draw();
                }
                if (snake.EatGG(foodGG))
                {
                    GameOver gameOver = new GameOver();
                    gameOver.GG(snake, sw);
                    break;
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandlKey(key.Key);
                }
                Thread.Sleep(snake.speed);
                snake.Move();
            }
        }
    }
}
