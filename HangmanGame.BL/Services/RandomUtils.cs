using HangmanGame.BL.Interfaces;
using HangmanGame.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame.BL.Services
{
    public class RandomUtils : IRandomUtils
    {
        public Word SelectRandomWordFromList(List<Word> list)
        {
            Random r = new Random();
            Word word = new Word();

            word = list[r.Next(0, list.Count)];

            return word;
        }
    }
}
