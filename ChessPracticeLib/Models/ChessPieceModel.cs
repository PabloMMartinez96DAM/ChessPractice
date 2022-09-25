using ChessPracticeLib.Enums;
using ChessPracticeLib.Interfaces;
using ChessPracticeLib.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessPracticeLib.Models
{
    public class ChessPieceModel : IChessPiece
    {

        public ChessPieceModel(TeamColor team,PieceType type)
        {
            this._type = type;
            this._team = team;
        }

        public TeamColor _team { get; set; }
        public TeamColor Team { get => _team; }

        private PieceType _type { get; set; }
        public PieceType Type { get=> _type;}

        public void Movement()
        {
            throw new NotImplementedException();
        }
    }
}
