using HangmanGame.DL.Models;
using System.Collections.Generic;

namespace HangmanGame.BL.Interfaces
{
    public interface IScoreboardManager
    {
        ScoreBoard CreateScoreBoard(User user, Word word, int guessCount, bool isCorrect);
        List<ScoreBoard> GetScoreBoards(string user);
    }
}