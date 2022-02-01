using ClassLibrary;

namespace SnakeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 35);
            int count=0;

            Walls walls = new Walls(80,25);
            walls.Drow();

            Point p = new Point(4, 5, '*');
            Figure snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Drow();

            while (true) 
            {
                if (walls.IsHit(snake) || snake.IsHitTail()) 
                {
                    break;
                }
                


                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Drow();
                    ++count;
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
            Console.Clear();
            Console.WriteLine($"Игра окончена. Ваш счет: {count}");
            Console.ReadKey();

        }


    }

}