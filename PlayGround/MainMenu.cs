using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using PlayGround.ticTacToe;

namespace PlayGround {
    class MainMenu {

        private List<IPlayable> playList = new List<IPlayable>();
        private int selection = -1;
        public MainMenu() {
            playList.Add(new TicTacToe());
        }

        public void getMainMenu() {
            bool running = true;

            while(running) {
                Console.WriteLine(getMenu());
                string input = getUserInput();
                if (input.ToLower().Equals("q")) break;
                if (inputIsValid(input)) {
                    playList[selection-1].Play();
                } else {
                    Console.WriteLine("Sorry, your input was invalid... Try again.");
                }
            }
            Console.WriteLine("Thanks for playing!");
            
        }

        private string getMenu() {
            return "**** WELCOME, SELECT A GAME ****\n" +
                "[1] Tic Tac Toe\n" +
                "[q] QUIT";
        }

        private string getUserInput() {
            string input = Console.In.ReadLine();
            return input;
        }

        private bool inputIsValid(string input) {
            if(!int.TryParse(input, out selection)) return false;
            if(selection-1 > -1 && selection-1 < playList.Count)
                return true;
            return false;
        }
    }
}
