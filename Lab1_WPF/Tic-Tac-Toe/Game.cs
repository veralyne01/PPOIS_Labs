using System;
namespace TicTacToe
{
    public class Game
    {
        private Player player1;
        private Player player2;
        public GameStat gameStat;
        public Player curPlayer;
        public enum GameStat
        {
            Win,
            Draw,
            InProcess
        }

        private int[] winCombinations =
        {
            0b000000111,
            0b000111000,
            0b111000000,
            0b001001001,
            0b100100100,
            0b001010100,
            0b100010001,
            0b010010010
        };

        public bool MakeMove(int row, int col)
        {
            int target = row * 3 + col;
            bool performed = false;
            if (InputValidator.ValidateMove(target, player1, player2))
            {
                curPlayer.map |= (1 << target);
                performed = true;
            }
            return performed;
        }
        public void CheckGameStat()
        {
            if (winCombinations.Any(comb => (comb & curPlayer.map) == comb))
            {
                gameStat = GameStat.Win;
            }
            else if ((player1.map | player2.map) == 0b111111111) { 
                gameStat = GameStat.Draw;
            }
        }

        public void SwitchPlayers()
        {
            if (curPlayer == player1) curPlayer = player2;
            else curPlayer = player1;
        }

        public void NewGame()
        {
            player1 = new Player(Player.Values.X);
            player2 = new Player(Player.Values.O);
            gameStat = GameStat.InProcess;
            curPlayer = player1;
        }

      
    }
}