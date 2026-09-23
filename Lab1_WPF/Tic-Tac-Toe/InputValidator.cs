using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class InputValidator
    {
        internal static bool ValidateMove(int target, Player player1, Player player2)
        {
            if (((player1.map | player2.map) & (1 << target)) == 0) return true;
            else return false;
        }
    }
}
