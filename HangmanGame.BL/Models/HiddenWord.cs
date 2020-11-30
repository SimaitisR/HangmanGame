using HangmanGame.DL.Models;
using System.Collections.Generic;

namespace HangmanGame.BL.Models
{
    class HiddenWord
    {
        internal Word Word { get; set; }
        internal int wordLength { get; set; }

        internal List<char> QuessedLetters { get; set; }
        internal List<char> CorrectLetters { get; set; }

        internal HiddenWord(Word word)
        {
            wordLength = word.Name.Length;
            Word = word;
            QuessedLetters = new List<char>();
            CorrectLetters = new List<char>();
        }
    }
}
