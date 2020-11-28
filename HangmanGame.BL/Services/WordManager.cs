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
