using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madu
{
    internal class Menu
    {
        private int selectedOption = 0;
        private string[] options = { "Play game", "Leaderbord" };
        private bool exit = false;
        private int da = 0;

        public void menu(Write write, FindBest findBest)
        {
            while (!exit)
            {
                Console.Clear();
                Console.SetCursorPosition(30, 10);
                Console.WriteLine("Menu");

                for (int i = 0; i < options.Length; i++)
                {
                    Console.SetCursorPosition(30, 12 + i);
                    if (i == selectedOption)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine(options[i]);
                }

                Console.ResetColor();

                var key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        selectedOption = (selectedOption - 1 + options.Length) % options.Length;
                        break;

                    case ConsoleKey.DownArrow:
                        selectedOption = (selectedOption + 1) % options.Length;
                        break;

                    case ConsoleKey.Enter:
                        ExecuteOption(write, findBest);
                        break;

                    case ConsoleKey.Escape:
                        exit = true;
                        break;
                }
            }
        }

        public void ExecuteOption(Write write, FindBest findBest)
        {
            Console.Clear();
            switch (selectedOption)
            {
                case 0:
                    exit = true;
                    da = 1;
                    break;
                case 1:
                    Option2(write, findBest);
                    break;
            }
            if (da == 0)
            {
                Console.WriteLine("\nPress any key to return to menu...");
                Console.ReadKey();
            }
            else if (da == 1)
            {
            }
        }
        public void Option2(Write write, FindBest findBest)
        {
            List<string> result = new List<string>(File.ReadAllLines(write.pathTotal));

            Console.SetCursorPosition(30, 10);
            Console.WriteLine("Best Player:");
            Console.SetCursorPosition(15, 12);
            findBest.findBest(write);
            Console.WriteLine(result[findBest.maxIndex]);

            Console.SetCursorPosition(15, 15);
            Console.WriteLine("All other players:");
            for (int i = 0; i < result.Count; i++)
            {
                if (i != findBest.maxIndex)
                {
                    Console.SetCursorPosition(15, 16 + i);
                    Console.WriteLine(result[i]);
                }
            }
        }
    }
}