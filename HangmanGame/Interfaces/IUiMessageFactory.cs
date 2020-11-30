using System.Collections.Generic;

namespace HangmanGame.Interfaces
{
    public interface IUiMessageFactory
    {
        void DefeatMessage();
        void DisplayHangman(int guessCount, string word, List<char> guessed, List<char> correct);
        void GuessedRight();
        void GuessedWrong();
        void FirstGuessMessage();
        void InputNameMessage();
        void SelectSubjectMessage();
        void VictoryMessage();
        void WelcomeMessage();
        void WelcomeToStatistics();
        void WrongInputMessage();
        void UsernameNotFound();
    }
}