using ChessPractice_Console.Enums;
using ChessPracticeLib.Enums;
using ChessPracticeLib.Interfaces;
using ChessPracticeLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ChessPracticeLib.Managers
{
    public class GameManager
    {
        private Board _myBoard { get; set; }
        private GameState _actualState = GameState.None;

        public GameManager(Board board)
        {
            this._myBoard = board;
        }

        public void StartGame()
        {
            Console.WriteLine("Welcome to Chess Practise");
            Console.WriteLine("Lets start a Game"); 

            this._actualState = GameState.StartGame;
            PrintBoard();
            GetTurn(TeamColor.White);
        }

        public void GetTurn(TeamColor turn)
        {

            switch (turn)
            {
                case TeamColor.White:
                    Console.WriteLine("Its White´s turn");
                    this._actualState = GameState.WhiteMovement;


                    // Testing
                    IChessPiece whiteKnight = new ChessPieceModel(TeamColor.White, PieceType.Knight);
                    PerformMovement(whiteKnight);

                    break;

                case TeamColor.Black:
                    Console.WriteLine("Its White´s turn");
                    this._actualState = GameState.WhiteMovement;
                    break;

                case TeamColor.None:
                    Console.WriteLine("There is an unusual ERROR: There is no valid Team assigned");
                    this._actualState = GameState.None;
                    break;
                default:
                    throw new Exception("What the fuck is going on");
                    break;

                   

            }


        }

        private void PerformMovement(IChessPiece actualPiece)
        {
            Cell currentCell = setCurrentCell();

            this._myBoard.GetNextLegalMoves(currentCell, actualPiece);
            PrintBoard();
        }

        public void GameOver()
        {
            this._actualState = GameState.EndGame;
        }


        private void PrintBoard()
        {

            string separator = "========";
            Console.WriteLine(separator);

            for (int i = 0; i < this._myBoard.Size; i++)
            {
                for (int j = 0; j < this._myBoard.Size; j++)
                {
                    Cell cell = this._myBoard.Grid[i, j];
                    if (cell.IsOccupied)
                    {
                        Console.Write("X");

                    }
                    else if (cell.IsLegal)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        // Its an empty square
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine(separator);
        }
        private  Cell setCurrentCell()
        {
            // get x and y coordinates and return actual cell

            Console.WriteLine("Introduce the current row number");
            int currentRow = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce the current column number");
            int currentColumn = int.Parse(Console.ReadLine());
            return this._myBoard.Grid[currentRow, currentColumn];
        }
    }
}
