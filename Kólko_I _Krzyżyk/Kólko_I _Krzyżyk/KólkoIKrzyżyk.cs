using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kółko_Krzyżyk
{
    class Program
    {
        static void Main(string[] args)
        {
            char player1 = 'X';
            char player2 = 'O';
            char[,] board = new char[3, 3];
            Initialize(board);
            int ruchy = 0;

            while (true)
            {
                Console.Clear();
                Print(board);

                Console.WriteLine("Podaj wiersz w którym chcesz postawić swój znak");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Podaj kolumne w której chcesz postawić swój znak");
                int col = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("row: " + row + " col: " + col);

                //player O
                board[row, col] = player2;
                if (player2 == board[0, 0] && player2 == board[0, 1] && player2 == board[0, 2])
                {
                    Console.WriteLine(player2 + " wygrał");
                    Print(board);
                    Console.ReadLine();
                    break;
                }
                if (player2 == board[1, 0] && player2 == board[1, 1] && player2 == board[1, 2])
                {
                    Console.WriteLine(player2 + " wygrał");
                    Print(board);
                    Console.ReadLine();
                    break;
                }
                if (player2 == board[2, 0] && player2 == board[2, 1] && player2 == board[2, 2])
                {
                    Console.WriteLine(player2 + " wygrał");
                    Print(board);
                    Console.ReadLine();
                    break;
                }
                if (player2 == board[0, 0] && player2 == board[1, 0] && player2 == board[2, 0])
                {
                    Console.WriteLine(player2 + " wygrał");
                    Print(board);
                    Console.ReadLine();
                    break;
                }
                if (player2 == board[0, 1] && player2 == board[1, 1] && player2 == board[2, 1])
                {
                    Console.WriteLine(player2 + " wygrał");
                    Print(board);
                    Console.ReadLine();
                    break;
                }
                if (player2 == board[0, 2] && player2 == board[1, 2] && player2 == board[2, 2])
                {
                    Console.WriteLine(player2 + " wygrał");
                    Print(board);
                    Console.ReadLine();
                    break;
                }
                if (player2 == board[0, 0] && player2 == board[1, 1] && player2 == board[2, 2])
                {
                    Console.WriteLine(player2 + " wygrał");
                    Print(board);
                    Console.ReadLine();
                    break;
                }
                if (player2 == board[2, 0] && player2 == board[1, 1] && player2 == board[0, 2])
                {
                    Console.WriteLine(player2 + " wygrał");
                    Print(board);
                    Console.ReadLine();
                    break;
                }
                //player X


                if (player1 == board[0, 0] && player1 == board[0, 1] && player1 == board[0, 2])
                {
                    Console.WriteLine(player1 + " wygrał");
                    Print(board);
                    Console.ReadLine();
                    break;
                }


                if (player1 == board[1, 0] && player1 == board[1, 1] && player1 == board[1, 2])
                {
                    Console.WriteLine(player1 + " wygrał");
                    Print(board);
                    Console.ReadLine();
                    break;
                }
                if (player1 == board[2, 0] && player1 == board[2, 1] && player1 == board[2, 2])
                {
                    Console.WriteLine(player1 + " wygrał");
                    Print(board);
                    Console.ReadLine();
                    break;
                }
                if (player1 == board[0, 0] && player1 == board[1, 0] && player1 == board[2, 0])
                {
                    Console.WriteLine(player1 + " wygrał");
                    Print(board);
                    Console.ReadLine();
                    break;
                }
                if (player1 == board[0, 1] && player1 == board[1, 1] && player1 == board[2, 1])
                {
                    Console.WriteLine(player1 + " wygrał");
                    Print(board);
                    Console.ReadLine();
                    break;
                }
                if (player1 == board[0, 2] && player1 == board[1, 2] && player1 == board[2, 2])
                {
                    Console.WriteLine(player1 + " wygrał");
                    Print(board);
                    Console.ReadLine();
                    break;
                }
                if (player1 == board[0, 0] && player1 == board[1, 1] && player1 == board[2, 2])
                {
                    Console.WriteLine(player1 + " wygrał");
                    Print(board);
                    Console.ReadLine();
                    break;
                }
                if (player1 == board[2, 0] && player1 == board[1, 1] && player1 == board[0, 2])
                {
                    Console.WriteLine(player1 + " wygrał");
                    Print(board);
                    Console.ReadLine();
                    break;
                }
                ruchy = ruchy + 1;
                if (ruchy == 9)
                {
                    Console.WriteLine("remis");
                    Print(board);
                    Console.ReadLine();
                    break;
                }
                player1 = ChangeTurn(player1);
                player2 = ChangeTurn(player2);
            }

        }
        static char ChangeTurn(char currentPlayer)
        {
            if (currentPlayer == 'X')
            {
                Console.ForegroundColor = ConsoleColor.Green;
                return 'O';

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return 'X';


            }

        }
        static void Initialize(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = ' ';

                }

            }
        }
        static void Print(char[,] board)
        {
            Console.WriteLine(" | 0 | 1 | 2 |");
            for (int row = 0; row < 3; row++)
            {
                Console.Write(row + "| ");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }

    }
}
