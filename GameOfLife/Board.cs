using System;

namespace GameOfLife
{
    public class Board
    {
        private bool[,] _cells;

        public int Rows { get; }
        public int Columns { get; }

        public Board(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            _cells = new bool[rows, columns];
        }

        public void Print()
        {
            Console.Clear();

            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Columns; c++)
                {
                    Console.Write(_cells[r, c] ? "O " : ". ");
                }
                Console.WriteLine();
            }
        }

        public void Clear()
        {
            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Columns; c++)
                {
                    _cells[r, c] = false;
                }
            }
        }
    }
}
