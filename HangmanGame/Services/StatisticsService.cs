using HangmanGame.BL.Interfaces;
using HangmanGame.BL.Services;
using HangmanGame.DL.Models;
using HangmanGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;


namespace HangmanGame.Services
{
    class StatisticsService : IStatisticsService
    {
        private readonly IUiMessageFactory _uiMessageFactory;
        private readonly IScoreboardManager _scoreBoardManager;

        public StatisticsService()
        {
            _uiMessageFactory = new UiMessageFactory();
            _scoreBoardManager = new ScoreboardManager();
        }

        public virtual void Begin()
        {
            Console.Clear();

            _uiMessageFactory.WelcomeToStatistics();
            DisplayAllAroundStatistics();

            Console.WriteLine("Paspauskite bet kuri klavisa gristi i pradini langa");
        }

        public virtual void DisplayAllAroundStatistics()
        {
            var sbList = _scoreBoardManager.GetAll();

            int correctGuesses = sbList.Select(x => x).Where(x => x.IsCorrect).Count();
            int incorrectGuesses = sbList.Select(x => x).Where(x=>!x.IsCorrect).Count();

            float cProc = (float)(correctGuesses * 100) / (correctGuesses + incorrectGuesses);
            float iProc = (float)(incorrectGuesses * 100) / (correctGuesses + incorrectGuesses);

            Console.WriteLine($"Bendra zaidimu statistika");
            Console.WriteLine($"Teisingai atspeti zodziai: {correctGuesses} : procentais {cProc}");
            Console.WriteLine($"Neteisingai atspeti zodziai: {incorrectGuesses} : procentais {iProc}");
            
        }
    }
}
