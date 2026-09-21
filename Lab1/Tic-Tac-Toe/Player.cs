using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    internal class Player
    {
        internal enum Values
        {
            X,
            O
        }
        internal int map;
        internal Values Sign;
        internal Player(Values sign)
        {
            map = 0;
            Sign = sign;
        }
    }
}
