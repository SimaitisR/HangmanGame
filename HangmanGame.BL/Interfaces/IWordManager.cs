using HangmanGame.DL.Models;
using System.Collections.Generic;

namespace HangmanGame.BL.Interfaces
{
    public interface IWordManager
    {
        void AddWordToPlayedList(Word word);
        List<Subject> GetSubjects();
        List<Word> GetWordsWithSubject(Subject subject);
        void IncreaseIncorrectCount(string word);
        void IncreaseWordPlayed(string word);
    }
}