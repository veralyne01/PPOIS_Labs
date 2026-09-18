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
        public int map;
        public Values Sign;
        public Player(Values sign)
        {
            map = 0;
            Sign = sign;
        }
    }
}
