
using System;

namespace Chess
{
    class ROOK   : ChessFigure
    {
        internal ROOK(string current) : base(current) { }

        internal override bool isMove(string nextCoord) {
            if ((nextCoord[0] != currentCoord[0]) && (nextCoord[1] != currentCoord[1]) || ((nextCoord[0] == currentCoord[0]) && (nextCoord[1] == currentCoord[1])))
                return false;
            else
                return true;
        }
    }
    class KNIGHT : ChessFigure
    {
        internal KNIGHT(string current) : base(current) { }

        internal override bool isMove(string nextCoord) {
            int dx, dy;
            dx = Math.Abs(nextCoord[0] - currentCoord[0]);
            dy = Math.Abs(nextCoord[1] - currentCoord[1]);
            if (!(Math.Abs(nextCoord[0] - currentCoord[0]) == 1 && Math.Abs(nextCoord[1] - currentCoord[1]) == 2 || Math.Abs(nextCoord[0] - currentCoord[0]) == 2 && Math.Abs(nextCoord[1] - currentCoord[1]) == 1))
                return false;
            else
                return true;
        }
    }
    class BISHOP : ChessFigure
    {
        internal BISHOP(string current) : base(current) { }

        internal override bool isMove(string nextCoord) {
            if (!(Math.Abs(nextCoord[0] - currentCoord[0]) == Math.Abs(nextCoord[1] - currentCoord[1])))
                return false;
            else
                return true;
        }
    }
    class PAWN   : ChessFigure
    {
        internal PAWN(string current) : base(current)  { }

        internal override bool isMove(string nextCoord) {
            if (nextCoord[0] != currentCoord[0] || nextCoord[1] <= currentCoord[1] || (nextCoord[1] - currentCoord[1] != 1 && (currentCoord[1] != '2' || nextCoord[1] != '4')))
                return false;
            else
                return true;
        }
    }
    class KING : ChessFigure
    {
        internal KING(string current) : base(current)  { }

        internal override bool isMove(string nextCoord) {
            if (!(Math.Abs(nextCoord[0] - currentCoord[0]) <= 1 && Math.Abs(nextCoord[1] - currentCoord[1]) <= 1))
                return false;
            else
                return true;
        }
    }

    class QUEEN  : ChessFigure
    {
        internal QUEEN(string current) : base(current) { }

        internal override bool isMove(string nextCoord) {
            if (!(Math.Abs(nextCoord[0] - currentCoord[0]) == Math.Abs(nextCoord[1] - currentCoord[1])
                || nextCoord[0] == currentCoord[0] || nextCoord[1] == currentCoord[1]))
                return false;
            else
                return true;
        }
    }

    abstract class ChessFigure {
        protected string currentCoord;
        internal ChessFigure(string current) { currentCoord = current; }

        internal bool Move(string nextCoord) { return isField(nextCoord) ? isMove(nextCoord) : false; }

        internal abstract bool isMove(string nextCoord);
        internal bool isField(string nextCoord) {
            return (nextCoord[0] >= 'A' && nextCoord[0] <= 'H' && nextCoord[1] >= '1' && nextCoord[1] <= '8');
        }
    }
}
