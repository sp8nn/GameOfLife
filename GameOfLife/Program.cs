using System;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(10, 20);

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
