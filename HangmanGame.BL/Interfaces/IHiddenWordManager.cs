using System.Collections.Generic;

namespace HangmanGame.BL.Interfaces
{
    public interface IHiddenWordManager
    {
        void AddCorrectLetterToHiddenWOrdList(char letter);
        void AddGuessedLetterToHiddenWordList(char letter);
        bool CheckIfHiddenWordContainsLetter(char inputLetter);
        List<char> GetCorrectLettersList();
        List<char> GetGuessedLettersList();
        int HiddenWordLength();
    }
}