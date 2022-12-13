using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicTacToe.Models
{
    public class Board
    {
        public int Dimension { get; set; } // The dimensions of the board, i.e., 5 means a 5x5 board
        public int PanelID { get; set; } = 0; // The ID Given to the buttons that represent the board
    }
}