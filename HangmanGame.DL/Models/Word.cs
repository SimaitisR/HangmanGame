using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HangmanGame.DL.Models
{
    [Table("Words")]
    public class Word
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
        public int WordPlayedCount { get; set; }
        public int WordNotGuessedCount { get; set; }
    }
}
