using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TicTacToe_WPF
{   
    public partial class MainWindow : Window
    {
        Board board = new Board();
        Player player1 = new Player("Player 1", true);
        Player player2 = new Player("Player 2", false);
        int turn = 1;
        int place = 0;

        public MainWindow()
        {
            InitializeComponent();

            TestWinCondition();
        }

        private void TestWinCondition()
        {
            if (board.IsGameEnded() == false && turn < 10)
            {
                LabelTurns.Content = "Current turn:" + turn.ToString();
            }
            else
            {
                if(turn > 9)
                {
                    LabelStatus.Content = "Tie Game";
                }
                else
                {
                    if((turn-1) % 2 == 0)
                    {
                        LabelStatus.Content = "End Game, " + player2.Name + " has won!";
                    }
                    else
                    {
                        LabelStatus.Content = "End Game, " + player1.Name + " has won!";
                    }
                }             
                Field1.IsEnabled = false;
                Field2.IsEnabled = false;
                Field3.IsEnabled = false;
                Field4.IsEnabled = false;
                Field5.IsEnabled = false;
                Field6.IsEnabled = false;
                Field7.IsEnabled = false;
                Field8.IsEnabled = false;
                Field9.IsEnabled = false;
                ButtonReset.Visibility = Visibility.Visible;
            }
        }

        private void Field1_Click(object sender, RoutedEventArgs e)
        {
            if(turn % 2 == 0)
            {
                if(board.SetPositions(1, player2.IsX))
                {
                    Field1.Content = "O";
                    turn++;
                }

            }
            else
            {
                if(board.SetPositions(1, player1.IsX))
                {
                    Field1.Content = "X";
                    turn++;
                }
            }           
            TestWinCondition();
        }

        private void Field2_Click(object sender, RoutedEventArgs e)
        {
            if (turn % 2 == 0)
            {
                if (board.SetPositions(2, player2.IsX))
                {
                    turn++;
                    Field2.Content = "O";
                }

            }
            else
            {
                if (board.SetPositions(2, player1.IsX))
                {
                    turn++;
                    Field2.Content = "X";
                }
            }           
            TestWinCondition();          
        }

        private void Field3_Click(object sender, RoutedEventArgs e)
        {
            if (turn % 2 == 0)
            {
                if (board.SetPositions(3, player2.IsX))
                {
                    turn++;
                    Field3.Content = "O";
                }

            }
            else
            {
                if (board.SetPositions(3, player1.IsX))
                {
                    turn++;
                    Field3.Content = "X";
                }
            }
            TestWinCondition();
        }

        private void Field4_Click(object sender, RoutedEventArgs e)
        {
            if (turn % 2 == 0)
            {
                if (board.SetPositions(4, player2.IsX))
                {
                    turn++;
                    Field4.Content = "O";
                }

            }
            else
            {
                if (board.SetPositions(4, player1.IsX))
                {
                    turn++;
                    Field4.Content = "X";
                }
            }
            TestWinCondition();
        }

        private void Field5_Click(object sender, RoutedEventArgs e)
        {
            if (turn % 2 == 0)
            {
                if (board.SetPositions(5, player2.IsX))
                {
                    turn++;
                    Field5.Content = "O";
                }

            }
            else
            {
                if (board.SetPositions(5, player1.IsX))
                {
                    turn++;
                    Field5.Content = "X";
                }
            }
            TestWinCondition();
        }

        private void Field6_Click(object sender, RoutedEventArgs e)
        {
            if (turn % 2 == 0)
            {
                if (board.SetPositions(6, player2.IsX))
                {
                    turn++;
                    Field6.Content = "O";
                }

            }
            else
            {
                if (board.SetPositions(6, player1.IsX))
                {
                    turn++;
                    Field6.Content = "X";
                }
            }
            TestWinCondition();
        }

        private void Field7_Click(object sender, RoutedEventArgs e)
        {
            if (turn % 2 == 0)
            {
                if (board.SetPositions(7, player2.IsX))
                {
                    turn++;
                    Field7.Content = "O";
                }

            }
            else
            {
                if (board.SetPositions(7, player1.IsX))
                {
                    turn++;
                    Field7.Content = "X";
                }
            }
            TestWinCondition();
        }

        private void Field8_Click(object sender, RoutedEventArgs e)
        {
            if (turn % 2 == 0)
            {
                if (board.SetPositions(8, player2.IsX))
                {
                    turn++;
                    Field8.Content = "O";
                }

            }
            else
            {
                if (board.SetPositions(8, player1.IsX))
                {
                    turn++;
                    Field8.Content = "X";
                }
            }
            TestWinCondition();
        }

        private void Field9_Click(object sender, RoutedEventArgs e)
        {
            if (turn % 2 == 0)
            {
                if (board.SetPositions(9, player2.IsX))
                {
                    turn++;
                    Field9.Content = "O";
                }

            }
            else
            {
                if (board.SetPositions(9, player1.IsX))
                {
                    turn++;
                    Field9.Content = "X";
                }
            }
            TestWinCondition();
        }

        private void ButtonReset_Click(object sender, RoutedEventArgs e)
        {
            ButtonReset.Visibility = Visibility.Collapsed;
            board = new Board();
            turn = 1;
            LabelTurns.Content = "Current turn:" + turn.ToString();
            LabelStatus.Content = "Game in Progress";
            Field1.IsEnabled = true;           
            Field2.IsEnabled = true;
            Field3.IsEnabled = true;
            Field4.IsEnabled = true;
            Field5.IsEnabled = true;
            Field6.IsEnabled = true;
            Field7.IsEnabled = true;
            Field8.IsEnabled = true;
            Field9.IsEnabled = true;
            Field1.Content = "";
            Field2.Content = "";
            Field3.Content = "";
            Field4.Content = "";
            Field5.Content = "";
            Field6.Content = "";
            Field7.Content = "";
            Field8.Content = "";
            Field9.Content = "";
        }
    }
}
