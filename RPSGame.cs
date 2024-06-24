using System;

namespace RPS_Game
{
    public class RPSGame
    {
        public static string GetWinner(string playerMove, string aiMove)
        {
            if (playerMove == aiMove) return "Tie";

            if ((playerMove == "r" && aiMove == "s") ||
                (playerMove == "p" && aiMove == "r") ||
                (playerMove == "s" && aiMove == "p"))
            {
                return "Player";
            }
            else
            {
                return "AI";
            }
        }

        public static void CompareMoves(Player player, Player aiPlayer)
        {
            Random random = new Random();
            int aiChoice = random.Next(0, 3);

            string playerMove = player.ChooseMove();
            string aiMove;

            switch (aiChoice)
            {
                case 0:
                    aiMove = "r";
                    Console.WriteLine("AI chooses Rock!");
                    break;
                case 1:
                    aiMove = "p";
                    Console.WriteLine("AI chooses Paper!");
                    break;
                case 2:
                    aiMove = "s";
                    Console.WriteLine("AI chooses Scissors!");
                    break;
                default:
                    throw new InvalidOperationException("Unexpected AI choice.");
            }

            string roundResult = GetWinner(playerMove, aiMove);

            switch (roundResult)
            {
                case "Player":
                    Console.WriteLine("You win this round!");
                    player.Score++;
                    break;
                case "AI":
                    Console.WriteLine("AI wins this round!");
                    aiPlayer.Score++;
                    break;
                case "Tie":
                    Console.WriteLine("It's a tie!");
                    break;
                default:
                    throw new InvalidOperationException("Unexpected round result.");
            }

            Console.WriteLine($"Scores ==> You: {player.Score}    AI: {aiPlayer.Score}");
            Console.WriteLine();
        }

        public static void ManageGameFlow(Player player, Player aiPlayer)
        {
            while (player.Score != 3 && aiPlayer.Score != 3)
            {
                CompareMoves(player, aiPlayer);
            }
            DisplayScores(player, aiPlayer);
        }

        public static void DisplayScores(Player player, Player aiPlayer)
        {
            if (player.Score == 3)
            {
                Console.WriteLine("Congratulations! You are the winner.");
                Console.WriteLine($"Your score ==> {player.Score}");
                Console.WriteLine($"AI score ==> {aiPlayer.Score}");
            }
            else
            {
                Console.WriteLine("AI is the winner, Good luck!");
                Console.WriteLine($"AI score ==> {aiPlayer.Score}");
                Console.WriteLine($"Your score ==> {player.Score}");
            }
        }
    }
}
