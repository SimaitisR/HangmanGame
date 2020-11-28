using HangmanGame.BL.Services;
using HangmanGame.DL;
using HangmanGame.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GameService s = new GameService();
            StatisticsService stats = new StatisticsService();

            PlayerManager pl = new PlayerManager();
            pl.DeleteUser(2);

            Console.WriteLine();
        }
    }
}
