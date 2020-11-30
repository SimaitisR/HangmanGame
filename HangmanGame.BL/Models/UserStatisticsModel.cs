using System;

namespace HangmanGame.BL.Models
{
    public class UserStatisticsModel
    {
        public string Name { get; set; }
        public string Word { get; set; }
        public DateTime TimePlayedAt { get; set; }
        public int GuessesMade { get; set; }
        public bool IsCorrect { get; set; }
    }
}
