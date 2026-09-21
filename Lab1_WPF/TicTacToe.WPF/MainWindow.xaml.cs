using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TicTacToe;

namespace TicTacToe.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TicTacToe.Game game;
        public MainWindow()
        {
            InitializeComponent();
            game = new();
            game.NewGame();
            textBox.Text = $"{game.curPlayer.Sign} moves";
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            game.MakeMove(Grid.GetRow(button), Grid.GetColumn(button));
            button.Content = game.curPlayer.Sign;
            game.CheckGameStat();
            if (game.gameStat == Game.GameStat.Win)
            {
                MessageBox.Show($"Player {game.curPlayer.Sign} wins!");
                this.Close();
            }
            else if (game.gameStat == Game.GameStat.Draw)
            {
                MessageBox.Show("Friendship wins!<3");
                this.Close();
            }
            else { 
                game.SwitchPlayers();
                textBox.Text = $"{game.curPlayer.Sign} moves";
            }
        }
    }
}