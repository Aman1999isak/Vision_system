using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Player
    {
        public int playerID { get; set; }
        public string playerName { get; set; }

        public bool solidball { get; set; }

        public bool halfball { get; set; }
        public bool playerTurn { get; set; }
        public Player()
        {

        }
    }
}
