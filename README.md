# RPS_Game# Rock, Paper, Scissors Game

This project implements a console-based Rock, Paper, Scissors game where a player competes against an AI opponent. The game allows players to choose their moves and determines the winner based on the classic rules of Rock beats Scissors, Scissors beats Paper, and Paper beats Rock.




## Features

- **Game Flow:** The game starts by welcoming the player and explaining the rules. It continues until either the player or the AI reaches a score of 3, indicating a winner.
  
- **Player Interaction:** The player inputs their move (either "R" for Rock, "P" for Paper, or "S" for Scissors) via the console. Input validation ensures that only valid moves are accepted.

- **AI Opponent:** The AI opponent randomly selects its move for each round. The AI's choice (Rock, Paper, or Scissors) is displayed after the player makes their move.

- **Game Logic:** After both the player and the AI have made their moves, the game determines the winner for that round based on the rules mentioned. Scores are updated accordingly for both the player and the AI.

- **End of Game:** Once a player reaches a score of 3, the game declares the winner (either the player or the AI) and displays the final scores. The game then concludes with a congratulatory message for the winner.

## Implementation

The project includes the following main components:

- **RPSGame Class:** Manages the game logic including determining the winner of each round (`GetWinner` method), comparing moves between the player and AI (`CompareMoves` method), and managing the game flow (`ManageGameFlow` method).

- **Player Class:** Represents the player, allowing them to choose their move ("R", "P", or "S").

- **Main Program:** Initializes the game by creating instances of the `Player` class and starts the game flow using methods from `RPSGame`.

This project provides a simple yet engaging implementation of Rock, Paper, Scissors game using console interactions and basic C# programming concepts.
