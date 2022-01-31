using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
   public  class Snake : Figure
    {
         Direction direction;

        public Snake(Point tail, int lenght, Direction direction) 
        {
            this.direction = direction;
            pList = new List<Point>();
            for (int i = 0; i<lenght;i++) 
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        public override void Move() 
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);
            tail.Clear();
            head.Drow();

            


        
        }

        public Point GetNextPoint() 
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        
        }

        public override void HandleKey(ConsoleKey key) 
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    direction = Direction.LEFT;
                    break;
                case ConsoleKey.RightArrow:
                    direction = Direction.RIGHT;
                    break;
                case ConsoleKey.DownArrow:
                    direction = Direction.DOWN;
                    break;
                case ConsoleKey.UpArrow:
                    direction = Direction.UP;
                    break;
            }
        }

        public override bool Eat(Point food) 
        {
            Point head = GetNextPoint();
            if (head.IsHit(food)) 
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;

            }
            else
                return false;

        }
    }
}
