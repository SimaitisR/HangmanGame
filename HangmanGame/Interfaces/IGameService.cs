using HangmanGame.DL.Models;
using System.Text;

namespace HangmanGame.Interfaces
{
    interface IGameService
    {
        void Begin();
        bool CheckIfWordIsGuessedCorrectly(string word, StringBuilder stringBuild);
        void CreateHiddenWordInstance(Word word);
        void GuessLetter(char inputLetter);
        Subject SelectSubjectFromList();
        void UpdateGuessCount();
    }
}