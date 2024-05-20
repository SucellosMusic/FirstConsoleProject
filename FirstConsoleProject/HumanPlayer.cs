using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace FirstConsoleProject
{
    public class HumanPlayer
    {
        public int play_turn()
        {
            int i = 0;
            int column;
            Console.WriteLine("Select a column number between 1 and 5");
            while (i == 0)
            {
                try
                {
                    column = Convert.ToInt32(Console.ReadLine());
                    i++;
                    return column;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid number, please choose an integer between 1 and 5");
                }
            }
            return 0;
        }
    }
}