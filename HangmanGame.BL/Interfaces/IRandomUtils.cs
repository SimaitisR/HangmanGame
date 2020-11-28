using HangmanGame.DL.Models;
using System.Collections.Generic;

namespace HangmanGame.BL.Interfaces
{
    public interface IRandomUtils
    {
        Word SelectRandomWordFromList(List<Word> list);
    }
}