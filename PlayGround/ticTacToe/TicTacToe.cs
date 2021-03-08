using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.ticTacToe {
    class TicTacToe : IPlayable {
        public void Play() {
            getTicTacToeBoard();
        }

        private void getTicTacToeBoard() {
            Console.WriteLine("tic tac toe board");
        }
    }
}
