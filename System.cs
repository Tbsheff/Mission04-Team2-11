using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class TicTacToeSystem
    {
        public class TicTacToeGame
        {
            // Method to print the Tic Tac Toe board
            public static void printBoard(string[,] board)
            {
                Console.WriteLine("Current Board:");
                // Print column labels
                Console.WriteLine("  A B C");
                for (int row = 0; row < 3; row++)
                {
                    // Print row label
                    Console.Write((row + 1) + " ");

                    for (int col = 0; col < 3; col++)
                    {
                        Console.Write(board[row, col] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            // Method to check for a winner and return the winning player
            public static bool checkWin(string[,] board)
            {
                // Check rows, columns, and diagonals
                for (int i = 0; i < 3; i++)
                {
                    // Check rows
                    if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != "_")
                    {
                        Console.WriteLine($"Player {board[i, 0]} wins!");
                        return true;
                    }
                    // Check columns
                    if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != "_")
                    {
                        Console.WriteLine($"Player {board[0, i]} wins!");
                        return true;
                    }
                }
                // Check diagonals
                if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != "_")
                {
                    Console.WriteLine($"Player {board[0, 0]} wins!");
                    return true;
                }
                if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != "_")
                {
                    Console.WriteLine($"Player {board[0, 2]} wins!");
                    return true;
                }
                return false; // No winner yet
            }
        }
    }
}
