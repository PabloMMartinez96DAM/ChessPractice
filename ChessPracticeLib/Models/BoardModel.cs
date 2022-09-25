using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessPracticeLib.Enums;
using ChessPracticeLib.Interfaces;

namespace ChessPracticeLib.Models
{
    public class Board
    {
        public int Size { get; set; }
        public Cell[,] Grid { get; set; }


        // Constructor
        public Board(int size)
        {
            this.Size = size;
            this.Grid = GetGrid(size);
        }

        private Cell[,] GetGrid(int size)
        {
            Cell[,] grid = new Cell[Size, Size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    grid[i, j] = new Cell(i, j);
                }
            }
            return grid;
        }


        public void GetNextLegalMoves(Cell currentCell,IChessPiece actualPiece)
        {
            ClearBoard();

            switch (actualPiece.Type)
            {
                case PieceType.None:
                    break;
                case PieceType.Pawn: 
                    break;
                case PieceType.Knight:
                    SetKnightLegalMoves(currentCell);

                    // Testing
                    this.Grid[currentCell.RankNumber, currentCell.FilesNumber].IsOccupied = true;
                    break;
                case PieceType.Bishop: 
                    break;
                case PieceType.Queen: 
                    break;
                case PieceType.King: 
                    break;

                    // I have to make a PerformMovement here because this code is unreacheble and because of that
                    // i have to paste in any case/breake sentence
                    //this.Grid[currentCell.RankNumber, currentCell.FilesNumber].IsOccupied = true;
            }
        }


        // Probably i will have to make a Move class 
        private void SetKnightLegalMoves(Cell currentCell)
        {
            this.Grid[currentCell.RankNumber + 2, currentCell.FilesNumber + 1].IsLegal = true;
            this.Grid[currentCell.RankNumber + 2, currentCell.FilesNumber - 1].IsLegal = true;
            this.Grid[currentCell.RankNumber - 2, currentCell.FilesNumber + 1].IsLegal = true;
            this.Grid[currentCell.RankNumber - 2, currentCell.FilesNumber - 1].IsLegal = true;
            this.Grid[currentCell.RankNumber + 2, currentCell.FilesNumber + 1].IsLegal = true;
            this.Grid[currentCell.RankNumber + 1, currentCell.FilesNumber + 2].IsLegal = true;
            this.Grid[currentCell.RankNumber + 1, currentCell.FilesNumber - 2].IsLegal = true;
            this.Grid[currentCell.RankNumber - 1, currentCell.FilesNumber + 2].IsLegal = true;
            this.Grid[currentCell.RankNumber - 1, currentCell.FilesNumber - 2].IsLegal = true;
        }

        private void ClearBoard()
        {
            for (int i = 0; i < this.Size; i++)
            {
                for (int j = 0; j < this.Size; j++)
                {
                    this.Grid[i, j].IsLegal = false;
                    this.Grid[i, j].IsOccupied = false;

                }

            }
        }
    }
}
