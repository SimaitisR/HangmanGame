using HangmanGame.BL.Interfaces;
using HangmanGame.DL;
using HangmanGame.DL.Models;
using System.Collections.Generic;
using System.Linq;

namespace HangmanGame.BL.Services
{
    public class PlayerManager : ICRUDRepository
    {
        public virtual void CreateUser(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                using (var context = new KartuvesDbContext())
                {
                    context.Users.Add(new User { Name = name });

                    context.SaveChanges();
                }
            }
        }

        public virtual void DeleteUser(int userId)
        {
            using (var context = new KartuvesDbContext())
            {
                var user = context.Users.FirstOrDefault(x => x.Id == userId);

                if (user != null)
                {
                    context.Users.Remove(user);

                    context.SaveChanges();
                }
            }
        }

        public virtual List<User>  ReadAllUsersData()
        {
            List<User> users = new List<User>();

            using (var context = new KartuvesDbContext())
            {
                users = context.Users.Select(x => x).ToList();

                context.SaveChanges();
            }
            return users;
        }

        public virtual User ReadUserData(int userId)
        {
            User user = new User();

            using (var context = new KartuvesDbContext())
            {
                user = context.Users.FirstOrDefault(u => u.Id ==userId);
            }
            return user;
        }



        public virtual void UpdateUser(User user,Word word, ScoreBoard scoreBoard)
        {
            using (var context = new KartuvesDbContext())
            {
                user = context.Users.FirstOrDefault(u => user.Id == u.Id);

                if (user != null && scoreBoard != null)
                {
                    user.ScoreBoards.Add(scoreBoard);
                    context.SaveChanges();
                }
            }
        }
    }
}
