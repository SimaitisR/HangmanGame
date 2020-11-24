using System.Collections.Generic;

namespace HangmanGame.Interfaces
{
    public interface IPictureFactory
    {
        void DisplayPicture(int incorrectGuessCount, string zodis, List<char> atspetosRaides, List<char> spetosRaides);
    }
}