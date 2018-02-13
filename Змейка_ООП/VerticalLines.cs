using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Змейка_ООП
{
    class VerticalLines : Figure
    {
        

        public VerticalLines(int yLeft, int yRight, int x, char sym)
        {
            pList=new List<Point>();
            for (int y = yLeft; y <= yRight; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

  
    }
}
