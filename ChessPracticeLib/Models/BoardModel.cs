using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public void GetNextLegalMoves(Cell currentCell,ChessPiecesEnum chessPiece)
        {
            ClearBoard();

            switch (chessPiece)
            {
                case ChessPiecesEnum.None:
                    break;
                case ChessPiecesEnum.Pawn: 
                    break;
                case ChessPiecesEnum.Knight:
                    SetKnightLegalMoves(currentCell);
                    break;
                case ChessPiecesEnum.Bishop: 
                    break;
                case ChessPiecesEnum.Queen: 
                    break;
                case ChessPiecesEnum.King: 
                    break;
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
