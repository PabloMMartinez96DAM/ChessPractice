using ChessPracticeLib.Models;
using System.Runtime.CompilerServices;

namespace ChessPractice_Console
{
    internal class Program
    {
        private static int _boardSize = 8;
        private static Board _myBoard = new Board(8);

        static void Main(string[] args)
        {
            PrintBoard(_myBoard);
            Console.ReadLine();
        }

        private static void PrintBoard(Board board)
        {

            string separator = "========";
            Console.WriteLine(separator);

            for (int i = 0; i < board.Size; i++)
            {
                for (int j = 0; j < board.Size; j++)
                {
                    Cell cell = board.Grid[i, j];
                    if (cell.IsOccupied)
                    {
                        Console.Write("X");

                    }
                    else if (cell.IsLegal)
                    {
                        Console.Write("Legal");
                    }
                    else
                    {
                        //its an empty square
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine(separator);
        }
    }
}