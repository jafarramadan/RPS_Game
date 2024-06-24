using System;
using System.ComponentModel.Design;
using RPS_Game;

namespace RPS_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("WELCOME TO ROCK - PAPER - SCISSER GAME!");
                Console.WriteLine("You and AI will play until one of you has score = 3");

                Player player = new Player();
                Player aiPlayer = new Player();

                RPSGame.ManageGameFlow(player, aiPlayer);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}