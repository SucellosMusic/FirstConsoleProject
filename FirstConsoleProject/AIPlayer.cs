using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace FirstConsoleProject
{
    public class AIPlayer
    {

        public int play_turn()
        {
            return RandomNumberGenerator.GetInt32(1, 5);
        }
    }
}