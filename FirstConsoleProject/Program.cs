// See https://aka.ms/new-console-template for more information
using System.Security;
using System.Security.Cryptography.X509Certificates;
using FirstConsoleProject;


namespace FirstConsoleProject
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            GameRules gameRules = new GameRules();
            int modeNumber = gameRules.get_mode_from_player();
            string mode = gameRules.set_mode(modeNumber);

            switch (mode)
            {
                case "PvP":
                    PvPMode newPPGame = new PvPMode();
                    newPPGame.play_pvp();
                    break;
                case "PvE":
                    PvEMode newPEGame = new PvEMode();
                    newPEGame.play_pve();
                    break;
            }

            Console.WriteLine("thank you for playing. Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
