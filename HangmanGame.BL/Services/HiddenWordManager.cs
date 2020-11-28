using HangmanGame.BL.Interfaces;
using HangmanGame.BL.Models;
using HangmanGame.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame.BL.Services
{
    public class HiddenWordManager : IHiddenWordManager
    {
        HiddenWord _hiddenWord { get; set; }
        public HiddenWordManager(Word word)
        {
            _hiddenWord = new HiddenWord(word);
        }
        public void AddGuessedLetterToHiddenWordList(char letter)
        {
            _hiddenWord.QuessedLetters.Add(letter);
        }
        public void AddCorrectLetterToHiddenWOrdList(char letter)
        {
            _hiddenWord.CorrectLetters.Add(letter);
        }
        public List<char> GetGuessedLettersList()
        {
            return _hiddenWord.QuessedLetters;
        }
        public List<char> GetCorrectLettersList()
        {
            return _hiddenWord.CorrectLetters;
        }
        public int HiddenWordLength()
        {
            return _hiddenWord.wordLength;
        }
        public bool CheckIfHiddenWordContainsLetter(char inputLetter)
        {
            if (_hiddenWord.Word.Name.Contains(inputLetter))
            {
                return true;
            }
            return false;
        }
    }
}
