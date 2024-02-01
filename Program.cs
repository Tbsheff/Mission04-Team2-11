using static System.Formats.Asn1.AsnWriter;
using System.Threading.Tasks;
using TicTacToe;

internal class Program
{
    private static void Main(string[] args)
    {
        // Welcome the user to the game
        //• Create a game board array to store the players’ choices
        //• Ask each player in turn for their choice and update the game board array
        //• Print the board by calling the method in the supporting class
        //• Check for a winner by calling the method in the supporting class, and notify the players
        // when a win has occurred and which player won the game
        Console.WriteLine("Welcome to Tic Tac Toe!\n");
        string[,] gameBoard =
        {
        {"_", "_", "_"},
        {"_", "_", "_"},
        {"_", "_", "_"}
    };

        TicTacToeSystem.TicTacToeGame.printBoard(gameBoard);


        bool gameOver = false;
        int row = 0;
        int column = 0;
        string input = "";
        string winner = "";
        bool validInput = false;
        do
        {
            validInput = false;
            while (!validInput)
            {
                Console.WriteLine("Player 1, please enter your row: ");
                input = Console.ReadLine();
                while (input != "1" && input != "2" && input != "3")
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 3: ");
                    input = Console.ReadLine();
                }
                row = int.Parse(input);
                Console.WriteLine("Player 1, please enter your column: ");
                input = Console.ReadLine();
                while (input != "A" && input != "B" && input != "C")
                {
                    Console.WriteLine("Invalid input. Please enter a valid column: ");
                    input = Console.ReadLine();
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
            gameBoard[row - 1, column] = "X";
            TicTacToeSystem.TicTacToeGame.printBoard(gameBoard);
            gameOver = TicTacToeSystem.TicTacToeGame.checkWin(gameBoard);
            if (gameOver)
            {
                winner = "Player 1";
                break;
            }
            Console.WriteLine("Player 2, please enter your row: ");
            input = Console.ReadLine();
            while (input != "1" && input != "2" && input != "3")
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 3: ");
                input = Console.ReadLine();
            }
            row = int.Parse(input);
            Console.WriteLine("Player 2, please enter your column: ");
            input = Console.ReadLine();
            while (input != "A" && input != "B" && input != "C")
            {
                Console.WriteLine("Invalid input. Please enter a valid column: ");
                input = Console.ReadLine();
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
            // Add the player's choice to the game board
            gameBoard[row - 1, column] = "O";

            TicTacToeSystem.TicTacToeGame.printBoard(gameBoard);
            // Print the game board
            //printBoard(gameBoard);
            // check if player 2 won
            //gameOver = checkWin(gameBoard);
            if (gameOver)
            {
                winner = "Player 2";
            }
        } while (!gameOver);
    }
}