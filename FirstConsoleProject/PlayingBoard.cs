using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace FirstConsoleProject
{
    public class PlayingBoard
    {
        private char[,] playingBoard = { { 'A', '_', '_', '_', '_', '_' }, { 'B', '_', '_', '_', '_', '_' }, { 'C', '_', '_', '_', '_', '_' }, { 'D', '_', '_', '_', '_', '_' }, { ' ', '1', '2', '3', '4', '5' } };

        public void assign_spot_to_player(string playerID, int col)
        {
            if (col > 0 && col <= 5)
                //player 1 is X
                //player 2 is O   
                switch (playerID)
                {
                    case "player1":
                        if (playingBoard[3, col] == '_')
                        {
                            playingBoard[3, col] = 'X';
                        }
                        else if (playingBoard[2, col] == '_')
                        {
                            playingBoard[2, col] = 'X';
                        }
                        else if (playingBoard[1, col] == '_')
                        {
                            playingBoard[1, col] = 'X';
                        }
                        else if (playingBoard[0, col] == '_')
                        {
                            playingBoard[0, col] = 'X';
                        }
                        else
                        {
                            Console.WriteLine("No available spot in column, try another.");
                        }
                        break;
                    case "player2":
                        if (playingBoard[3, col] == '_')
                        {
                            playingBoard[3, col] = 'O';
                        }
                        else if (playingBoard[2, col] == '_')
                        {
                            playingBoard[2, col] = 'O';
                        }
                        else if (playingBoard[1, col] == '_')
                        {
                            playingBoard[1, col] = 'O';
                        }
                        else if (playingBoard[0, col] == '_')
                        {
                            playingBoard[0, col] = 'O';
                        }
                        else
                        {
                            Console.WriteLine("No available spot in column, try another.");
                        }
                        break;
                    default:
                        Console.WriteLine("invalid playerID");
                        break;
                }
            else
            {
                Console.WriteLine("Invalid column number, please choose betwee 1 and 5");
            }
        }

        public void show_board()
        {
            for (int i = 0; i < playingBoard.GetLength(0); i++)
            {
                for (int j = 0; j < playingBoard.GetLength(1); j++)
                {
                    Console.Write("|");
                    Console.Write(playingBoard[i, j]);
                    Console.Write("|");
                }
                Console.WriteLine(" ");
            }
        }


        public int declare_winner()
        {
            WinConditions winConditions = new WinConditions();
            winConditions.fill_win_conditions(playingBoard);
            int winningPlayer = winConditions.determine_winner();
            if (winningPlayer == 1)
            {
                return 1;
            }
            if (winningPlayer == 2)
            {
                return 2;
            }
            if (winningPlayer == 3)
            {
                return 3;
            }
            return 0;
        }
    }
}