using HangmanGame.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
