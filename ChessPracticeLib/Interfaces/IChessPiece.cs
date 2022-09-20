using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessPracticeLib.Interfaces
{
    internal interface IChessPiece
    {
        ChessPiecesEnum ChessPiece { get; }
        string Name { get => Enum.GetName(this.ChessPiece); }
    }
}
