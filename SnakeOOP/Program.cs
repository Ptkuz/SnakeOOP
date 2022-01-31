using ClassLibrary;

namespace SnakeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure HorlineUp = new HorizontallLine(0, 90, 0, '-');
            Figure VerLineLeft = new VerticalLine(0, 25, 0, '|');
            Figure HorlineDown = new HorizontallLine(0, 90, 25, '-');
            Figure VerLineRigth = new VerticalLine(0, 25, 90, '|');


            Console.SetWindowSize(100, 35);

            Point p = new Point(4, 5, '*');
            Figure snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            List<Figure> figures = new List<Figure>();
            figures.Add(HorlineUp);
            figures.Add(VerLineLeft);
            figures.Add(HorlineDown);
            figures.Add(VerLineRigth);

            foreach (Figure f in figures) 
            { 
                f.Drow();
            }



            FoodCreator foodCreator = new FoodCreator(90, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Drow();

            while (true) 
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Drow();
                }
                else 
                {
                    snake.Move();
                
                }

                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);

                }
            }

        }


    }

}