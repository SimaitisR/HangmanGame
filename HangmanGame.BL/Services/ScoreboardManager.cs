using HangmanGame.BL.Interfaces;
using HangmanGame.DL;
using HangmanGame.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame.BL.Services
{
    public class ScoreboardManager : IScoreboardManager
    {
        public virtual ScoreBoard CreateScoreBoard(User user, Word word, int guessCount, bool isCorrect)
        {
            ScoreBoard sb = new ScoreBoard()
            {
                User = user,
                Word = word,
                WordToGuess = word.Name,
                Time = DateTime.UtcNow,
                GuessCount = guessCount,
                IsCorrect = isCorrect
            };
            using (var context = new KartuvesDbContext())
            {
                context.ScoreBoards.Add(sb);
                context.SaveChanges();
            }

            return sb;
        }

        public virtual List<ScoreBoard> GetScoreBoards(string user)
        {
            List<ScoreBoard> sb = new List<ScoreBoard>();
            using (var context = new KartuvesDbContext())
            {
                sb = context.ScoreBoards.Select(x => x).Where(u => u.User.Name == user).ToList();
            }
            return sb;
        }
    }
}
