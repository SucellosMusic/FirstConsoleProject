using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstConsoleProject
{
    public class PvEMode
    {
        PlayingBoard board = new PlayingBoard();
        HumanPlayer player1 = new HumanPlayer();
        AIPlayer player2 = new AIPlayer();
        public void play_pve()
        {
            Console.WriteLine("Welcome Players");
            board.show_board();
            while (board.declare_winner() == 0)
            {
                Console.WriteLine("Player 1: ");
                board.assign_spot_to_player("player1", player1.play_turn());
                board.show_board();
                if (board.declare_winner() == 1)
                {
                    Console.WriteLine("player1 is the winner");
                    break;
                }
                else
                {
                    Console.WriteLine("Player 2: ");
                    board.assign_spot_to_player("player2", player2.play_turn());
                    board.show_board();
                    if (board.declare_winner() == 2)
                    {
                        Console.WriteLine("player2 is the winner");
                        break;
                    }
                }
                if (board.declare_winner() == 3)
                {
                    Console.WriteLine("DRAW");
                    break;
                }
            }
        }
    }

}