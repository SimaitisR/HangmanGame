using HangmanGame.BL.Interfaces;
using HangmanGame.BL.Services;
using HangmanGame.DL.Models;
using HangmanGame.Interfaces;
using System;
using System.Collections.Generic;


namespace HangmanGame.Services
{
    class StatisticsService : IStatisticsService
    {
        private IUiMessageFactory _uiMessageFactory;
        private IScoreboardManager _scoreBoardManager;

        public StatisticsService()
        {
            _uiMessageFactory = new UiMessageFactory();
            _scoreBoardManager = new ScoreboardManager();
        }

        public virtual void Begin()
        {
            Console.Clear();

            _uiMessageFactory.WelcomeToStatistics();
            _uiMessageFactory.InputNameMessage();

            string input = Console.ReadLine();

            List<ScoreBoard> sbList = new List<ScoreBoard>();

            sbList = _scoreBoardManager.GetScoreBoards(input);

            if (sbList.Count == 0)
            {
                _uiMessageFactory.UsernameNotFound();

            }
            else
            {
                foreach (var item in sbList)
                {
                    Console.WriteLine($"Zaidejo vardas: {input} ");
                    Console.WriteLine($"Spetas zodis: {item.WordToGuess}");
                    Console.WriteLine($"Ar atspetas zodis? : {item.IsCorrect}");
                    Console.WriteLine($"Spejimu skaicius : {item.GuessCount}");
                    Console.WriteLine($"Kada zaista : {item.Time}");
                }
            }

            Console.WriteLine("Paspauskite bet kuri klavisa gristi i pradini langa");
        }
    }
}
