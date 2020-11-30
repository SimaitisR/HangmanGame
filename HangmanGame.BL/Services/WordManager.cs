using HangmanGame.BL.Interfaces;
using HangmanGame.DL;
using HangmanGame.DL.Models;
using System.Collections.Generic;
using System.Linq;

namespace HangmanGame.BL.Services
{
    public class WordManager : IWordManager
    {
        List<Word> _playedWords{ get; set; }

        public WordManager()
        {
            _playedWords = new List<Word>();
        }

        public void AddWordToPlayedList(Word word)
        {
            _playedWords.Add(word);
        }
        public virtual void IncreaseWordPlayed(string word)
        {
            using (var context = new KartuvesDbContext())
            {
                var inc = context.Words.FirstOrDefault(x => x.Name == word);
                inc.WordPlayedCount++;

                context.SaveChanges();
            }
        }
        public virtual void IncreaseIncorrectCount(string word)
        {
            using (var context = new KartuvesDbContext())
            {
                var inc = context.Words.FirstOrDefault(x => x.Name == word);
                inc.WordNotGuessedCount++;

                context.SaveChanges();
            }
        }

        public List<Subject> GetSubjects()
        {
            List<Subject> subjects = new List<Subject>();
            using (var context = new KartuvesDbContext())
            {
                subjects = context.Subjects.Select(x => x).ToList();
            }
            return subjects;
        }
        public List<Word> GetWordsWithSubject(Subject subject)
        {
            List<Word> words = new List<Word>();
            using (var context = new KartuvesDbContext())
            {
                words = context.Words.Select(x => x).Where(name => name.SubjectId == subject.Id).ToList();
            }
            return words;
        }
    }
}
