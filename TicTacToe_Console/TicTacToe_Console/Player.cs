using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console
{
    class Player
    {
        private string name;
        private bool isX;

        public string Name 
        {
            get
            { 
                return name;
            }
        }

        public bool IsX
        {
            get { return isX; }
        }


        public Player(string name, bool isX)
        {
            this.name = name;
            this.isX = isX;
        }
    }
}
