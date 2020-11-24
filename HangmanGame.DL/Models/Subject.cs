using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HangmanGame.DL.Models
{
    [Table("Subjects")]
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Word> Words { get; set; }
    }
}
