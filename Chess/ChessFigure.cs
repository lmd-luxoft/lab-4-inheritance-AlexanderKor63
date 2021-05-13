
using System;

namespace Chess
{
    class ROOK   : ChessFigure
    {
        internal ROOK(string current) : base(current) { }

        internal override bool canMove(string nextCoord) {
            return !((nextCoord[0] != currentCoord[0]) && (nextCoord[1] != currentCoord[1]) ||
                ((nextCoord[0] == currentCoord[0]) && (nextCoord[1] == currentCoord[1])));
        }
    }

    class KNIGHT : ChessFigure
    {
        internal KNIGHT(string current) : base(current) { }

        internal override bool canMove(string nextCoord) {
            return (Math.Abs(nextCoord[0] - currentCoord[0]) == 1 && Math.Abs(nextCoord[1] - currentCoord[1]) == 2
                || Math.Abs(nextCoord[0] - currentCoord[0]) == 2 && Math.Abs(nextCoord[1] - currentCoord[1]) == 1);
        }
    }

    class BISHOP : ChessFigure
    {
        internal BISHOP(string current) : base(current) { }

        internal override bool canMove(string nextCoord) {
            return (Math.Abs(nextCoord[0] - currentCoord[0]) == Math.Abs(nextCoord[1] - currentCoord[1]));
        }
    }

    class PAWN   : ChessFigure
    {
        internal PAWN(string current) : base(current)  { }

        internal override bool canMove(string nextCoord) {
            return !(nextCoord[0] != currentCoord[0] || nextCoord[1] <= currentCoord[1] ||
                (nextCoord[1] - currentCoord[1] != 1 && (currentCoord[1] != '2' || nextCoord[1] != '4')));
        }
    }

    class KING : ChessFigure
    {
        internal KING(string current) : base(current)  { }

        internal override bool canMove(string nextCoord) {
            return Math.Abs(nextCoord[0] - currentCoord[0]) <= 1 && Math.Abs(nextCoord[1] - currentCoord[1]) <= 1;
        }
    }

    class QUEEN  : ChessFigure
    {
        internal QUEEN(string current) : base(current) { }

        internal override bool canMove(string nextCoord) {
            return Math.Abs(nextCoord[0] - currentCoord[0]) == Math.Abs(nextCoord[1] - currentCoord[1])
                || nextCoord[0] == currentCoord[0] || nextCoord[1] == currentCoord[1];
        }
    }

    abstract class ChessFigure {
        protected string currentCoord;
        internal ChessFigure(string current) { currentCoord = current; }

        internal bool Move(string nextCoord) {
            return isField(nextCoord) ?
                 (!canMove(nextCoord) ? false : true) : false;
        }

        internal abstract bool canMove(string nextCoord);

        protected bool isField(string nextCoord) {
            return (nextCoord[0] >= 'A' && nextCoord[0] <= 'H' && nextCoord[1] >= '1' && nextCoord[1] <= '8');
        }
    }
}
