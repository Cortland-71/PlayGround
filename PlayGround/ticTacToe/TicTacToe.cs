using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.ticTacToe {
    class TicTacToe : IPlayable {

        private List<List<string>> board = new List<List<string>>();

        public void Play() {
            populateEmptyBoard();
            getTicTacToeBoard();
        }

        private void getTicTacToeBoard() {
            
            foreach(List<string> row in board) {
                foreach(string item in row) {
                    Console.Write($"[{item}]");
                }
                Console.WriteLine();
            }
        }

        private void populateEmptyBoard() {
            for (int i = 0; i < 3; i++) {
                var list = new List<string>();
                for(int j = 0; j < 3; j++) {
                    list.Add("_");
                }
                board.Add(list);
            }
        }

        
    }
}
