using HangmanGame.Interfaces;
using HangmanGame.Services;
using System;

namespace HangmanGame
{
    static class Program
    {
        static void Main(string[] args)
        {
            bool exitProgram = false;

            IUiMessageFactory uiMessageFactory = new UiMessageFactory();
            IGameService gameService = new GameService();
            IStatisticsService statsService = new StatisticsService();

            while (!exitProgram)
            {
                Console.Clear();
                uiMessageFactory.WelcomeMessage();

                if (Console.ReadKey().Key == ConsoleKey.D1)
                {
                    statsService.Begin();
                }
                if (Console.ReadKey().Key == ConsoleKey.D2)
                {
                    gameService.Begin();
                }

                if(Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    exitProgram = true;
                }
            }
        }
    }
}
