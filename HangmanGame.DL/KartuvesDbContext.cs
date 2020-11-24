using HangmanGame.DL.Models;
using System.Data.Entity;

namespace HangmanGame.DL
{
    public class KartuvesDbContext : DbContext
    {
        public KartuvesDbContext() : base("HangmanGame")
        {
            Database.SetInitializer(new KartuvesDbInitializer());
        }
        public DbSet<Word> Words { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<ScoreBoard> ScoreBoards { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
