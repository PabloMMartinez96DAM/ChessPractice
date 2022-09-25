
using ChessPracticeLib.Managers;
using ChessPracticeLib.Models;
using System.Runtime.CompilerServices;


namespace ChessPractice_Console
{
    internal class Program
    {
        private static int _boardSize = 8;
        private static Board _myBoard = new Board(8);

        private static GameManager  _gameManager = new GameManager(_myBoard);

        static void Main(string[] args)
        {
            _gameManager.StartGame();
           


         

            Console.ReadLine();
        }

       

       
    }
}