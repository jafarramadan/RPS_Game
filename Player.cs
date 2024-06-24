using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Game
{
    public class Player
    {
        private string name;
        private int score;

        public Player() { }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public string ChooseMove()
        {
            Console.WriteLine("Please enter your move: R | P | S");
            string playerChoice = Console.ReadLine()?.Trim().ToLower();

            while (playerChoice != "r" && playerChoice != "p" && playerChoice != "s")
            {
                Console.WriteLine("Invalid input! Please enter one of these choices (R, P, S)");
                playerChoice = Console.ReadLine()?.Trim().ToLower();
            }

            return playerChoice;
        }
    }
}