using System;
namespace TicTacToe
{
    class Game
    {
        private Player player1;
        private Player player2;
        private GameStat gameStat;
        private Player curPlayer;
        private enum GameStat
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

        private void MakeMove()
        {
            int? row = null, col = null;
            while (row == null)
            {
                try { row = InputValidator.ValidateInt(); }
                catch (Exception e) { Console.WriteLine(e); }
            }
            while (col == null)
            {
                try { col = InputValidator.ValidateInt(); }
                catch (Exception e) { Console.WriteLine(e); }
            }
            int target = Convert.ToInt32(row * 3 + col);
            if (InputValidator.ValidateMove(target, player1, player2)) curPlayer.map |= (1 << target);
            else
            {
                Console.WriteLine("This cell is already occupied!\n");
                SwitchPlayers();
            }
        }
        private void CheckGameStat()
        {
            if (winCombinations.Any(comb => (comb & curPlayer.map) == comb))
            {
                gameStat = GameStat.Win;
                Console.WriteLine($"Player {curPlayer.Sign} wins!");
            }
            else if ((player1.map | player2.map) == 0b111111111) { 
                gameStat = GameStat.Draw;
                Console.WriteLine("Friendship wins <3");
            }
        }

        private void SwitchPlayers()
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

        public void Play()
        {
            while (gameStat == GameStat.InProcess)
            {
                MakeMove();
                CheckGameStat();
                SwitchPlayers();
            }
        }
    }
}