using ChessPracticeLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessPracticeLib.Interfaces
{
    public interface IChessPiece
    {
        TeamColor Team { get;}
        PieceType Type { get;}
        string Name { get => Enum.GetName(this.Type); }
        void Movement();

        
    }
}
