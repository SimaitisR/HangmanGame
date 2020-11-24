using HangmanGame.Interfaces;
using System;
using System.Collections.Generic;

namespace HangmanGame.Services
{
    public class PictureFactory : IPictureFactory
    {
        readonly static List<char> charList = new List<char>() { '|', 'o', '|', '\\', '/', 'O', '/', '\\', '|' };
        public void DisplayPicture(int incorrectGuessCount, string zodis,
            List<char> atspetosRaides,
            List<char> spetosRaides)
        {
            DrawHangman(incorrectGuessCount);
            DrawGuessingPart(zodis, atspetosRaides, spetosRaides);
        }

        static void DrawGuessingPart(string zodis,
            List<char> atspetosRaides,
            List<char> spetosRaides)
        {

            Console.Write("Zodis:");
            for (int i = 0; i < zodis.Length; i++)
            {
                if (atspetosRaides.Count > 0 && atspetosRaides.Contains(zodis[i]))
                {
                    Console.Write($"{zodis[i]}");
                }
                else
                    Console.Write("_");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.Write("Spetos raides: ");
            foreach (var item in spetosRaides)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
        static void DrawHangman(int input)
        {
            int[] usedParts = new int[8];
            for (int i = 1; i <= input; i++)
            {
                usedParts[i] = i;
            }
            Console.Clear();

            Console.WriteLine($"|-------{charList[0]}");
            Console.WriteLine($"|       {ReturnHangmanPart(usedParts[1])}");
            Console.WriteLine($"|      {ReturnHangmanPart(usedParts[3])}{ReturnHangmanPart(usedParts[2])}{ReturnHangmanPart(usedParts[4])}");
            Console.WriteLine($"|       {ReturnHangmanPart(usedParts[5])}");
            Console.WriteLine($"|      {ReturnHangmanPart(usedParts[6])} {ReturnHangmanPart(usedParts[7])}");
            Console.WriteLine($"|");
            Console.WriteLine($"|");
            Console.WriteLine($"|");
            Console.WriteLine($"|");
            Console.WriteLine($"|----");
        }

        static char ReturnHangmanPart(int i)
        {
            if (i != 0)
                return charList[i];
            else return ' ';
        }
    }
}
