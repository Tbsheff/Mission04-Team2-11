using static System.Formats.Asn1.AsnWriter;
using System.Threading.Tasks;
using TicTacToe;

internal class Program
{
    private static void Main(string[] args)
    {
    
        Console.WriteLine("Welcome to Tic Tac Toe!\n"); // Welcome user to the game
        // Initialize the game board
        string[,] gameBoard =
        {
        {"_", "_", "_"},
        {"_", "_", "_"},
        {"_", "_", "_"}
    };

        // Print the game board
        TicTacToeSystem.TicTacToeGame.printBoard(gameBoard);

        // Initialize variables
        bool gameOver = false;
        int row = 0;
        int column = 0;
        string input = "";
        string winner = "";
        bool validInput = false;

        // Main game loop
        do
        {
            validInput = false;
            while (!validInput) // Loop until the player enters a valid input
            {
                // Prompt the user to enter a row and column
                Console.WriteLine("Player X, please enter your row: ");
                input = Console.ReadLine();

                // Check if the input is a valid number
                while (input != "1" && input != "2" && input != "3")
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 3: ");
                    input = Console.ReadLine();
                }

                row = int.Parse(input);
                Console.WriteLine("Player X, please enter your column: ");
                input = Console.ReadLine().ToUpper();

                // Check if the input is a valid column
                while (input != "A" && input != "B" && input != "C")
                {
                    Console.WriteLine("Invalid input. Please enter a valid column: ");
                    input = Console.ReadLine().ToUpper();
                }

                // Change letter column to number column
                if (input == "A")
                {
                    column = 0;
                }
                else if (input == "B")
                {
                    column = 1;
                }
                else if (input == "C")
                {
                    column = 2;
                }

                // Check if the spot is taken
                if (gameBoard[row - 1, column] == "_")
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("That spot is already taken. Please choose another spot.");
                }
            }

            // Add the player's choice to the game board
            gameBoard[row - 1, column] = "X";

            TicTacToeSystem.TicTacToeGame.printBoard(gameBoard); // Print the game board
            gameOver = TicTacToeSystem.TicTacToeGame.checkWin(gameBoard); // Check for a winner

            // Check for a draw
            if (!gameOver)
            {
                bool draw = true;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (gameBoard[i, j] == "_")
                        {
                            draw = false;
                        }
                    }
                }
                if (draw)
                {
                    Console.WriteLine("The game is a draw!");
                    gameOver = true;
                }
            }
            // break if winner or draw
            if (gameOver)
            {
                break;
            }

            validInput = false;
            while (!validInput) // Loop until the next player enters a valid input
            {
                // Prompt the user to enter a row and column
                Console.WriteLine("Player O, please enter your row: ");
                input = Console.ReadLine();

                // Check if the input is a valid number
                while (input != "1" && input != "2" && input != "3")
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 3: ");
                    input = Console.ReadLine();
                }

                row = int.Parse(input);
                Console.WriteLine("Player O, please enter your column: ");
                input = Console.ReadLine().ToUpper();

                // Check if the input is a valid column
                while (input != "A" && input != "B" && input != "C")
                {
                    Console.WriteLine("Invalid input. Please enter a valid column: ");
                    input = Console.ReadLine().ToUpper();
                }

                // Change letter column to number column
                if (input == "A")
                {
                    column = 0;
                }
                else if (input == "B")
                {
                    column = 1;
                }
                else if (input == "C")
                {
                    column = 2;
                }

                // Check if the spot is taken
                if (gameBoard[row - 1, column] == "_")
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("That spot is already taken. Please choose another spot.");
                }
            }

            // Add the player's choice to the game board
            gameBoard[row - 1, column] = "O";

            // Print the game board
            TicTacToeSystem.TicTacToeGame.printBoard(gameBoard);

            // Check for a winner
            gameOver = TicTacToeSystem.TicTacToeGame.checkWin(gameBoard);

            // Check for a draw

            if (!gameOver)
            {
                bool draw = true;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (gameBoard[i, j] == "_")
                        {
                            draw = false;
                        }
                    }
                }
                if (draw)
                {
                    Console.WriteLine("The game is a draw!");
                    gameOver = true;
                }
            }

        } while (!gameOver);
    }
}