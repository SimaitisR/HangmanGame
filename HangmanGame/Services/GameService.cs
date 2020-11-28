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

    class GameService : IGameService
    {
        private IWordManager _wordManager;
        private IUiMessageFactory _uiMessageFactory;
        private IRandomUtils _randomUtils;
        private IHiddenWordManager _hiddenWordManager;
        private ICRUDRepository _playerManager;

        private Subject _selectedSubject;
        private List<Word> _wordListWithSubject;
        private const int spejimuSkaicius = 7;
        private int neteisingiSpejimai = 0;
        private bool isWordGuessedCorrectly = false;

        public GameService()
        {
            _uiMessageFactory = new UiMessageFactory();
            _wordManager = new WordManager();
            _randomUtils = new RandomUtils();
            _selectedSubject = new Subject();
            _wordListWithSubject = new List<Word>();
            _playerManager = new PlayerManager();
        }

        public void Begin()
        {
            _uiMessageFactory.InputNameMessage();

            User user = new User();
            user.Name = Console.ReadLine();
            _playerManager.CreateUser(user.Name);

            _selectedSubject = SelectSubjectFromList();
            _wordListWithSubject = _wordManager.GetWordsWithSubject(_selectedSubject);

            Word selectedWord = _randomUtils.SelectRandomWordFromList(_wordListWithSubject);

            CreateHiddenWordInstance(selectedWord);
            _wordManager.AddWordToPlayedList(selectedWord);

            _uiMessageFactory.InputMessage();

            StringBuilder stringBuild = new StringBuilder();
            for (int i = 0; i < selectedWord.Name.Length; i++)
            {
                stringBuild.Append('_');
            }

            while (neteisingiSpejimai < spejimuSkaicius || isWordGuessedCorrectly)
            {
                string input = Console.ReadLine();
                foreach (var item in input)
                {
                    GuessLetter(item);
                }

                _uiMessageFactory.DisplayHangman(
                    neteisingiSpejimai,
                    selectedWord.Name,
                    _hiddenWordManager.GetGuessedLettersList(),
                    _hiddenWordManager.GetCorrectLettersList());

                CheckIfWordIsGuessedCorrectly(selectedWord.Name, stringBuild);
            }

            if (isWordGuessedCorrectly)
                _uiMessageFactory.VictoryMessage();
            else
                _uiMessageFactory.DefeatMessage();

            RemoveWordFromList(selectedWord);

            //ADD TO STATISTICS
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
                isWordGuessedCorrectly = true;
                return true;
            }
            else
            {
                isWordGuessedCorrectly = false;
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
            _hiddenWordManager.AddGuessedLetterToHiddenWordList(inputLetter);
            if (_hiddenWordManager.CheckIfHiddenWordContainsLetter(inputLetter))
            {
                _hiddenWordManager.AddCorrectLetterToHiddenWOrdList(inputLetter);
            }
            else
            {
                UpdateGuessCount();
            }

        }

        public virtual void UpdateGuessCount()
        {
            neteisingiSpejimai++;
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
