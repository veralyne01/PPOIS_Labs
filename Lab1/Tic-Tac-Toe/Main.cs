using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Start
    {
        private static void Main(string[] args)
        {
            Game game = new Game();
            game.NewGame();
            game.Play();
        }
    }
}
