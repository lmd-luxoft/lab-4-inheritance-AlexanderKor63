
using System;

namespace Chess
{
    class ROOK   : ChessFigure
    {
        internal ROOK(string current) : base(current) { }
        internal override bool FMove(string nextCoord) {
            if (nextCoord[0] >= 'A' && nextCoord[0] <= 'H' && nextCoord[1] >= '1' && nextCoord[1] <= '8')
            {
                if ((nextCoord[0] != currentCoord[0]) && (nextCoord[1] != currentCoord[1]) || ((nextCoord[0] == currentCoord[0]) && (nextCoord[1] == currentCoord[1])))
                    return false;
                else
                    return true;
            }
            else return false;
        }
    }
    class KNIGHT : ChessFigure
    {
        internal KNIGHT(string current) : base(current) { }
        internal override bool FMove(string nextCoord)   {
            if (nextCoord[0] >= 'A' && nextCoord[0] <= 'H' && nextCoord[1] >= '1' && nextCoord[1] <= '8')
            {
                int dx, dy;
                dx = Math.Abs(nextCoord[0] - currentCoord[0]);
                dy = Math.Abs(nextCoord[1] - currentCoord[1]);
                if (!(Math.Abs(nextCoord[0] - currentCoord[0]) == 1 && Math.Abs(nextCoord[1] - currentCoord[1]) == 2 || Math.Abs(nextCoord[0] - currentCoord[0]) == 2 && Math.Abs(nextCoord[1] - currentCoord[1]) == 1))
                    return false;
                else
                    return true;
            }
            else return false;
        }
    }
    class BISHOP : ChessFigure
    {
        internal BISHOP(string current) : base(current) { }
        internal override bool FMove(string nextCoord)   {
            if (nextCoord[0] >= 'A' && nextCoord[0] <= 'H' && nextCoord[1] >= '1' && nextCoord[1] <= '8')
            {
                if (!(Math.Abs(nextCoord[0] - currentCoord[0]) == Math.Abs(nextCoord[1] - currentCoord[1])))
                    return false;
                else
                    return true;
            }
            else return false;
        }
    }
    class PAWN   : ChessFigure
    {
        internal PAWN(string current) : base(current) { }
        internal override bool FMove(string nextCoord) {
            if (nextCoord[0] >= 'A' && nextCoord[0] <= 'H' && nextCoord[1] >= '1' && nextCoord[1] <= '8')
            {
                if (nextCoord[0] != currentCoord[0] || nextCoord[1] <= currentCoord[1] || (nextCoord[1] - currentCoord[1] != 1 && (currentCoord[1] != '2' || nextCoord[1] != '4')))
                    return false;
                else
                    return true;
            }
            else return false;
            }
    }
    class KING   : ChessFigure
    {
        internal KING(string current) : base(current) { }
        internal override bool FMove(string nextCoord) {
            if (nextCoord[0] >= 'A' && nextCoord[0] <= 'H' && nextCoord[1] >= '1' && nextCoord[1] <= '8')
            {
                if (!(Math.Abs(nextCoord[0] - currentCoord[0]) <= 1 && Math.Abs(nextCoord[1] - currentCoord[1]) <= 1))
                    return false;
                else
                    return true;
            }
            else return false;
        }
    }

    class QUEEN  : ChessFigure
    {
        internal QUEEN(string current) : base(current) { }
        internal override bool FMove(string nextCoord)  {
            if (nextCoord[0] >= 'A' && nextCoord[0] <= 'H' && nextCoord[1] >= '1' && nextCoord[1] <= '8')
            {
                if (!(Math.Abs(nextCoord[0] - currentCoord[0]) == Math.Abs(nextCoord[1] - currentCoord[1]) || nextCoord[0] == currentCoord[0] || nextCoord[1] == currentCoord[1]))
                    return false;
                else
                    return true;
            }
            else return false;
        }
    }

    abstract class ChessFigure {
        protected string currentCoord;
        internal ChessFigure(string current) { currentCoord = current; }

        internal abstract bool FMove(string nextCoord);
        internal bool Move(string nextCoord) {  return FMove(nextCoord); }
    }
}
