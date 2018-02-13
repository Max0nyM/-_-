using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Змейка_ООП
{
    class Snake : Figure
    {
        Directions dirs;

        public Snake(Point tail, int lenght, Directions dir)
        {
            pList=new List<Point>();
            dirs = dir;
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i,Directions.RIGHT);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1,dirs);
            return nextPoint;
        }

        public void HandleKey(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.LeftArrow)
            {
                dirs = Directions.LEFT;
            }
            if (key.Key == ConsoleKey.RightArrow)
            {
                dirs = Directions.RIGHT;
            }
            if (key.Key == ConsoleKey.UpArrow)
            {
                dirs = Directions.UP;
            }
            if (key.Key == ConsoleKey.DownArrow)
            {
                dirs = Directions.DOWN;
            }
        }

        public bool Eat(Point foodPoint)
        {
            Point head = GetNextPoint();
            if (head.isHit(foodPoint))
            {
                foodPoint.sym = head.sym;
                pList.Add(foodPoint);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
