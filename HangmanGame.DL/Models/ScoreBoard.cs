using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HangmanGame.DL.Models
{
    [Table("ScoreBoard")]
    public class ScoreBoard
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int WordId { get; set; }
        public virtual Word Word { get; set; }
        public string WordToGuess { get; set; }
        public DateTime Time { get; set; }
        public bool IsCorrect { get; set; }
        public int GuessCount { get; set; }
    }
}
