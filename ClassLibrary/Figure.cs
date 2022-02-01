using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Figure
    {

        protected List<Point> pList;
        public virtual void Drow()
        {
            foreach (Point p in pList)
                p.Drow();

        }

        public virtual bool Eat(Point food) 
        {
            return false;
        
        }
        public virtual void Move() 
        {

        }

        public virtual void HandleKey(ConsoleKey key) { }


        public bool IsHit(Figure figure)
        {
            foreach (var p in pList)
            {
                if (figure.IsHit(p))
                    return true;
            }
            return false;
        }

        private bool IsHit(Point point)
        {
            foreach (var p in pList)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }

        public virtual bool IsHitTail() 
        {
            return false;
        
        }
    }
}
