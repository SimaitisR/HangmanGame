using HangmanGame.DL.Models;
using System.Collections.Generic;

namespace HangmanGame.BL.Interfaces
{
    public interface ICRUDRepository
    {
        void CreateUser(string name);
        List<User> ReadAllUsersData();
        User ReadUserData(int userId);
        void DeleteUser(int userId);
        void UpdateUser(User user, Word word, ScoreBoard scoreBoard);
    }
}
