﻿using HangmanGame.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
