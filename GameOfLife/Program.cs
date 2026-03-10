using System;
using System.Threading;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(20, 40);

            board.Randomize();

            while (true)
            {
                board.Print();
                board.NextGeneration();

                Thread.Sleep(200);
            }

            board.Print();

            Console.WriteLine("\nPress any key to clear the board...");
            Console.ReadKey();

            board.Clear();
            board.Print();

            Console.WriteLine("\nBoard cleared.");
            Console.ReadKey();
        }
    }
}
