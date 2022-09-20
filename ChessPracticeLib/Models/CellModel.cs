using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessPracticeLib.Models
{
    public class Cell
    {
        // Rows
        public int RankNumber { get; set; }
        // Files
        public int FilesNumber { get; set; }
        public bool IsOccupied { get; set; }
        public bool IsLegal { get; set; }

        public Cell(int x, int y)
        {
            RankNumber = x;
            FilesNumber = y;
        }
    }
}
