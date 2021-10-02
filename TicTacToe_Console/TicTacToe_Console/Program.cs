using System;

namespace TicTacToe_Console
{
    class Program
    {       
        static void Main(string[] args)
        {
            Board board = new Board();
            Player player1 = new Player("Player 1",true);
            Player player2 = new Player("Player 2",false);
            int turn = 0;
            int place = 0;
            bool wantToPlay = true;
            string decision = null;

            while (wantToPlay)
            {
                Console.Clear();
                while (board.IsGameEnded() == false && turn < 9)
                {
                    turn++;
                    Console.WriteLine("Current turn: {0}\n", turn);
                    board.Print();
                    if (turn % 2 == 0)
                    {
                        Console.WriteLine("\n{0} please select where you want to play", player2.Name);
                        try
                        {
                            place = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please enter a number");
                        }
                        while (!board.SetPositions(place, player2.IsX))
                        {
                            Console.WriteLine("\n Invalid position, please choice another:");
                            place = int.Parse(Console.ReadLine());
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n{0} please select where you want to play", player1.Name);
                        try
                        {
                            place = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please enter a number");
                        }
                        while (!board.SetPositions(place, player1.IsX))
                        {
                            Console.WriteLine("\n Invalid position, please choice another:");
                            place = int.Parse(Console.ReadLine());
                        }
                    }
                    Console.Clear();
                }

                Console.WriteLine("\nEND GAME\n");

                if (board.IsGameEnded() == false)
                {
                    Console.WriteLine("TIE GAME\n");
                }
                else
                {
                    if (turn % 2 == 0)
                    {
                        Console.WriteLine("THE WINNER IS: {0}\n", player2.Name);
                    }
                    else
                    {
                        Console.WriteLine("THE WINNER IS: {0}\n", player1.Name);
                    }
                }

                Console.WriteLine("TURNS PLAYED: {0}", turn);
                board.Print();
                Console.WriteLine("Want to play again? (Y/N)");
                decision = Console.ReadLine();
                if(decision != "Y" && decision != "y")
                {
                    Console.WriteLine(decision);
                    wantToPlay = false;
                }
                board = new Board();
                turn = 0;
            }

        }
    }
}
