using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace FirstConsoleProject
{
    public class GameRules
    {
        public int get_mode_from_player()
        {
            Console.WriteLine("Please select a game mode: 1=PvP, 2=PvE.");
            int i = 0;
            while (i == 0)
            {
                try
                {
                    int modeNumber = Convert.ToInt32(Console.ReadLine());
                    i = 1;
                    return modeNumber;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please choose an integer between 1 and 3");
                }
            }
            return 0;
        }
        public string set_mode(int get_mode_from_player)
        {
            int modeNumber = get_mode_from_player;
            if (modeNumber == 1)
            {
                return "PvP";
            }
            else if (modeNumber == 2)
            {
                return "PvE";
            }
            else
            {
                Console.WriteLine("Invalid mode");
                return "invalid mode";
            }
        }
    }
}