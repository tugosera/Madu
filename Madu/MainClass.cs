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
            Console.ForegroundColor = ConsoleColor.Magenta;
            walls.Draw();
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Point p = new Point(50, 7, '*');
            Snake snake = new Snake(p, 7, Direction.Left);
            snake.Drow();
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Green;
            FoodCreator foodCreator = new FoodCreator(80, 35, '&');
            Point food = foodCreator.CreateFood();
            food.Draw();
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Yellow;
            FoodCreator foodCreatorSpeed = new FoodCreator(80, 35, '#');
            Point foodSpeed = foodCreatorSpeed.CreateFoodSpeed();
            foodSpeed.Draw();
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            FoodCreator foodCreatorSlow = new FoodCreator(80, 35, '¤');
            Point foodSlow = foodCreatorSlow.CreateFoodSlow();
            foodSlow.Draw();
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Red;
            FoodCreator foodCreatorGG = new FoodCreator(80, 35, 'X');
            Point foodGG = foodCreatorGG.CreateFoodGG();
            foodGG.Draw();
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.White;
            FoodCreator foodCreatorRand = new FoodCreator(80, 35, '?');
            Point foodRand = foodCreatorRand.CreateFood();
            foodRand.Draw();
            Console.ForegroundColor = ConsoleColor.White;

            Console.SetCursorPosition(3, 40);
            Console.Write("& - 1 score");
            Console.SetCursorPosition(3, 42);
            Console.Write("# - 1 score and + 10speed");
            Console.SetCursorPosition(3, 44);
            Console.Write("¤ - 1 score and - 10speed");
            Console.SetCursorPosition(40, 40);
            Console.Write("X - Game Over");
            Console.SetCursorPosition(40, 42);
            Console.Write("? - Game Over OR + 10 score OR nothing");

            while (true)
            {

                Random random = new Random();
                int Rand1 = random.Next(1, 3);

                Console.SetCursorPosition(5, 1);
                Console.Write("Score: {0}", snake.gool);

                Console.SetCursorPosition(50, 1);
                Console.Write("Time: {0}", sw);

                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    Console.Clear();
                    GameOver gameOver = new GameOver();
                    gameOver.GG(snake, sw);
                    break;
                }
                if(snake.Eat(food))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    food = foodCreator.CreateFood();
                    food.Draw();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (snake.EatSpeed(foodSpeed))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    foodSpeed = foodCreatorSpeed.CreateFoodSpeed();
                    foodSpeed.Draw();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (snake.EatSlow(foodSlow))
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    foodSlow = foodCreatorSlow.CreateFoodSlow();
                    foodSlow.Draw();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (snake.EatGG(foodGG))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    GameOver gameOver = new GameOver();
                    gameOver.GG(snake, sw);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                if (snake.EatRand(foodRand))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    if (Rand1 == 1)
                    {
                        snake.gool += 10;
                    }
                    else if (Rand1 == 2)
                    {
                        Console.Clear();
                        GameOver gameOver = new GameOver();
                        gameOver.GG(snake, sw);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandlKey(key.Key);
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Thread.Sleep(snake.speed);
                snake.Move();
            }
        }
    }
}
