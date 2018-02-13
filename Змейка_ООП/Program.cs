using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Змейка_ООП
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.SetBufferSize( 80, 30);
            HorizintalLines upLine = new HorizintalLines(0, Console.WindowWidth - 2, 0, '+');
            HorizintalLines downLine = new HorizintalLines(0, Console.WindowWidth - 2, Console.WindowHeight - 1, '+');
            VerticalLines RightLine = new VerticalLines(0, Console.WindowHeight - 1, 0, '+');
            VerticalLines LeftLine = new VerticalLines(0, Console.WindowHeight - 1, Console.WindowWidth - 2, '+');
            upLine.Draw();
            downLine.Draw();
            RightLine.Draw();
            LeftLine.Draw();
            Point p = new Point(5, 6, '*');
            Snake snake = new Snake(p, 5, Directions.RIGHT);
            snake.Draw();
            FoodCreator foodCreator = new FoodCreator(Console.WindowWidth, Console.WindowHeight,'*');
            Point food = foodCreator.CreateFood();
            food.Draw();
            while (true)
            {
                if (snake.Eat(food))
                {
                   food = foodCreator.CreateFood();
                    food.Draw();

                }
                else
                {
                    snake.Move();
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key);
                }
                Thread.Sleep(100);
              
            }

        }

       
    }
}
