using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class Player
    {
        public enum Values
        {
            X,
            O
        }
        internal int map;
        public Values Sign;
        internal Player(Values sign)
        {
            map = 0;
            Sign = sign;
        }
    }
}
