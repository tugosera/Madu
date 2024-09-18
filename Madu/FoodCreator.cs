using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madu
{
    internal class FoodCreator
    {
        int mapWidht;
        int mapHeight;
        char sym;

        Random random = new Random(); 

        public FoodCreator(int mapWidht, int mapHeight, char sym)
        {
            this.mapWidht = mapWidht;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = random.Next( 2, mapWidht - 2 );
            int y = random.Next( 3, mapHeight - 2 );
            return new Point(x, y, sym);
        }

        public Point CreateFoodSpeed()
        {
            int x = random.Next(2, mapWidht - 2);
            int y = random.Next(3, mapHeight - 2);
            return new Point(x, y, sym);
        }

        public Point CreateFoodSlow()
        {
            int x = random.Next(2, mapWidht - 2);
            int y = random.Next(3, mapHeight - 2);
            return new Point(x, y, sym);
        }

        public Point CreateFoodGG()
        {
            int x = random.Next(2, mapWidht - 2);
            int y = random.Next(3, mapHeight - 2);
            return new Point(x, y, sym);
        }
    }
}
