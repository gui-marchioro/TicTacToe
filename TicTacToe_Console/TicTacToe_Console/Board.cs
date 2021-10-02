using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console
{    
    public class Board
    {
        const string SYMBOL1 = "X";
        const string SYMBOL2 = "O";
        private string[,] positions = new string[3, 3]
        {
            { "1", "2", "3"},
            { "4", "5", "6"},
            { "7", "8", "9"}
        };
        public Board()
        {

        }
        public void Print()
        {
            for(int boardRow = 0; boardRow < 9; boardRow++)
            {
                if(boardRow == 1 || boardRow == 4 || boardRow == 7)
                {
                    Console.WriteLine("  {0}  |  {1}  |  {2}  ", positions[boardRow/3, 0], positions[boardRow / 3, 1], positions[boardRow / 3, 2]);
                }
                else if(boardRow == 2 || boardRow == 5)
                {
                    Console.WriteLine("_____|_____|_____");
                }
                else
                {
                    Console.WriteLine("     |     |     ");
                }
            }
        }
        public bool SetPositions(int place, bool isX)
        {
            // if position is out of bounds return false
            if(place > 9 || place < 1)
            {
                return false;
            }

            int row = 2;
            int collum = 0;

            DecodePlace(place, ref row, ref collum);

            // if position is already filled return false
            if (positions[row, collum] == SYMBOL1 || positions[row, collum] == SYMBOL2)
            {
                return false;
            }
            // fill with the right symbol
            else
            {
                if (isX == true)
                {
                    positions[row, collum] = SYMBOL1;
                }
                else
                {
                    positions[row, collum] = SYMBOL2;
                }
            }
            return true;
        }
        public bool IsGameEnded()
        {
            string letter = null;
            string letterNext = null;

            // Line Condition
            for (int row = 0; row < 3; row++)
            {
                for (int collum = 0; collum < 2; collum++)
                {
                    letter = positions[row, collum];
                    letterNext = positions[row, (collum+1)];

                    if (letter != letterNext)
                    {
                        break;
                    }
                    if(collum == 1 && letter == letterNext)
                    {
                        return true;
                    }
                }
            }

            // Collum Condition
            for (int collum = 0; collum < 3; collum++)
            {
                for (int row = 0; row < 2; row++)
                {
                    letter = positions[row, collum];
                    letterNext = positions[(row + 1), collum];

                    if (letter != letterNext)
                    {
                        break;
                    }
                    if (row == 1 && letter == letterNext)
                    {
                        return true;
                    }
                }
            }

            // Diagonal Condition
            for (int index = 0; index < 2; index++)
            {
                letter = positions[index, index];
                letterNext = positions[(index+1), (index + 1)];

                if (letter != letterNext)
                {
                    break;
                }
                if (index == 1 && letter == letterNext)
                {
                    return true;
                }
            }

            // Inverse Diagonal Condition
            for (int collum = 0, row = 2; collum < 2; collum++, row--)
            {
                letter = positions[row, collum];
                letterNext = positions[(row - 1), (collum + 1)];
                if (letter != letterNext)
                {
                    break;
                }
                if (collum == 1 && letter == letterNext)
                {
                    return true;
                }
            }
            return false;
        }
        private void DecodePlace(int place, ref int row, ref int collum)
        {
            // first row test
            if (place < 4)
            {
                row = 0;
            }
            // second row test
            else if (place < 7)
            {
                row = 1;
            }
            // third collum test
            if ((place - row * 3) % 3 == 0)
            {
                collum = 2;
            }
            // second collum test
            else if ((place - row * 3) % 2 == 0)
            {
                collum = 1;
            }
        }
    }
}
