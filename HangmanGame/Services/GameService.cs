using HangmanGame.BL.Interfaces;
using HangmanGame.BL.Services;
using HangmanGame.DL.Models;
using HangmanGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HangmanGame.Services
{

    class GameService :  IGameService
    {
        private readonly IWordManager _wordManager;
        private readonly IUiMessageFactory _uiMessageFactory;
        private readonly IRandomUtils _randomUtils;
        private readonly ICRUDRepository _playerManager;
        private readonly IScoreboardManager _scoreBoardManager;
        
        private const int maxGuess = 7;

        private IHiddenWordManager _hiddenWordManager;
        private List<Word> _wordListWithSubject;
        private int guessCount;
        private int incorrectGuess;
        private bool isWordGuessedCorrectly;
        public Subject selectedSubject { get; set; }

        public GameService()
        {
            _uiMessageFactory = new UiMessageFactory();
            _wordManager = new WordManager();
            _randomUtils = new RandomUtils();
            _wordListWithSubject = new List<Word>();
            _playerManager = new PlayerManager();
            _scoreBoardManager = new ScoreboardManager();
        }

        public void Begin()
        {
            Clear();

            _uiMessageFactory.InputNameMessage();

            User user = new User();
            user.Name = Console.ReadLine();
            _playerManager.CreateUser(user.Name);

            selectedSubject = SelectSubjectFromList();
            _wordListWithSubject = _wordManager.GetWordsWithSubject(selectedSubject);

            Word selectedWord = _randomUtils.SelectRandomWordFromList(_wordListWithSubject);
            _wordManager.IncreaseWordPlayed(selectedWord.Name);

            CreateHiddenWordInstance(selectedWord);
            _wordManager.AddWordToPlayedList(selectedWord);

            _uiMessageFactory.FirstGuessMessage();

            StringBuilder stringBuild = new StringBuilder();
            for (int i = 0; i < selectedWord.Name.Length; i++)
            {
                stringBuild.Append('_');
            }
            _uiMessageFactory.DisplayHangman(
                    incorrectGuess,
                    selectedWord.Name,
                    _hiddenWordManager.GetGuessedLettersList(),
                    _hiddenWordManager.GetCorrectLettersList());

            while (incorrectGuess < maxGuess && !isWordGuessedCorrectly)
            {
                string input = Console.ReadLine().ToUpper();
                foreach (var item in input)
                {
                    GuessLetter(item);
                }

                _uiMessageFactory.DisplayHangman(
                    incorrectGuess,
                    selectedWord.Name,
                    _hiddenWordManager.GetGuessedLettersList(),
                    _hiddenWordManager.GetCorrectLettersList());

                isWordGuessedCorrectly = CheckIfWordIsGuessedCorrectly(selectedWord.Name, stringBuild);
            }

            if (isWordGuessedCorrectly)
                _uiMessageFactory.VictoryMessage();
            else
            {
                _uiMessageFactory.DefeatMessage();
                _wordManager.IncreaseIncorrectCount(selectedWord.Name);
            }

            RemoveWordFromList(selectedWord);
            SaveScoreBoard(user, selectedWord);
        }

        private void Clear()
        {
            Console.Clear();
            isWordGuessedCorrectly = false;
            guessCount = 0;
            incorrectGuess = 0;
        }

        private void SaveScoreBoard(User user, Word selectedWord)
        {
            _scoreBoardManager.CreateScoreBoard(
                            user,
                            selectedWord,
                            guessCount,
                            isWordGuessedCorrectly);
        }

        public virtual bool CheckIfWordIsGuessedCorrectly(string word, StringBuilder stringBuild)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (_hiddenWordManager.GetCorrectLettersList().Count > 0
                    && _hiddenWordManager.GetCorrectLettersList().Contains(word[i]))
                {
                    stringBuild.Replace('_', word[i], i, 1);
                }
            }
            if (stringBuild.ToString() == word)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual Subject SelectSubjectFromList()
        {
            _uiMessageFactory.SelectSubjectMessage();
            var subjects = _wordManager.GetSubjects();

            foreach (var item in subjects)
            {
                Console.WriteLine($"{item.Id} - {item.Name}");
            }
            int input = 0;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                _uiMessageFactory.WrongInputMessage();
                int.TryParse(Console.ReadLine(), out input);
            }

            while (subjects.FirstOrDefault(subj => subj.Id == input) == null)
            {
                input = Convert.ToInt32(Console.ReadLine());
            }
            return subjects.First(sub => sub.Id == input);
        }
        public virtual void GuessLetter(char inputLetter)
        {
            GuessCount();
            _hiddenWordManager.AddGuessedLetterToHiddenWordList(inputLetter);
            if (_hiddenWordManager.CheckIfHiddenWordContainsLetter(inputLetter))
            {
                _hiddenWordManager.AddCorrectLetterToHiddenWOrdList(inputLetter);
            }
            else
            {
                UpdateIncorrectGuessCount();
            }
        }

        private void GuessCount()
        {
            guessCount++;
        }

        public virtual void UpdateIncorrectGuessCount()
        {
            incorrectGuess++;
        }

        public virtual void CreateHiddenWordInstance(Word word)
        {
            _hiddenWordManager = new HiddenWordManager(word);
        }
        void RemoveWordFromList(Word word)
        {
            _wordListWithSubject.Remove(word);
        }
    }
}
