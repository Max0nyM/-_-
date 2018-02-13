using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Змейка_ООП
{
    class FoodCreator
    {
        private int mapWith, mapHeight;
        private char sym;
        public FoodCreator(int mapWith, int mapHeight, char sym)
        {
            this.sym = sym;
            this.mapHeight = mapHeight;
            this.mapWith = mapWith;
        }

        public Point CreateFood()
        {
            Random rand = new Random();
            int x = rand.Next(3, mapWith - 3);
            int y = rand.Next(3, mapHeight - 3);
            return new Point(x,y,sym);
        }
    }
}
