namespace ClassLibrary
{
    public class Point
    {
         int x;
         int y;
         public char sym;

        public Point(int x, int y, char sym) 
        { 
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public Point(Point p) 
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        
        }

        public void Move(int offset, Direction direction) 
        {
            switch (direction) 
            {
                case Direction.RIGHT:
                    x = x + offset;
                    break;
                case Direction.LEFT:
                    x = x - offset;
                    break;
                case Direction.UP:
                    y = y - offset;
                    break;
                case Direction.DOWN:
                    y = y + offset;
                    break;


            }
                
        
        }

        public void Drow() 
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        
        }

        public void Clear() 
        {
            sym = ' ';
            Drow();
        
        }

        public bool IsHit(Point p) 
        { 
            return p.x == x && p.y == y;
        }
    }
}