using HangmanGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame.Services
{
    public class UiMessageFactory : IUiMessageFactory
    {
        private readonly IPictureFactory _pictureFactory;
        public UiMessageFactory()
        {
            _pictureFactory = new PictureFactory();
        }
        public virtual void InputNameMessage()
        {
            Console.WriteLine("Iveskite zaidejo varda");
        }
        public virtual void InputMessage()
        {
            Console.WriteLine("Zaidimas prasidejo!");
            Console.WriteLine("Atlikite pirma spejima!");
        }
        public virtual void WrongInputMessage()
        {
            Console.WriteLine("Neteisingai ivesta reiksme");
            Console.WriteLine("Bandykite dar karta...");
        }
        public virtual void GuessedWrong()
        {
            Console.WriteLine("Neteisingas spejimas!");
        }
        public virtual void GuessedRight()
        {
            Console.WriteLine("Teisingas spejimas!");
        }
        public virtual void SelectSubjectMessage()
        {
            Console.WriteLine("Pasirinkite tema zodziamas!");
            Console.WriteLine("Nurodykite temos skaiciu: ");
        }
        public virtual void VictoryMessage()
        {
            Console.WriteLine("----------------++++++++++++++----------------");
            Console.WriteLine(" PERGALE! Sveikinu laimejus kartuviu zaidima!");
            Console.WriteLine("----------------++++++++++++++----------------");
        }
        public virtual void DefeatMessage()
        {
            Console.WriteLine("----------------++++++++++++++----------------");
            Console.WriteLine("Prailaimejimas... Sekmes zaidziant kita karta!");
            Console.WriteLine("----------------++++++++++++++----------------");
        }
        public virtual void WelcomeMessage()
        {
            Console.WriteLine("----------------++++++++++++++----------------");
            Console.WriteLine("Sveiki atvyke i kartuviu zaidima!");
            Console.WriteLine("Pasirinkite ka noresite daryti: ");
            Console.WriteLine("Iveskite 1: Perziurekite statistika ");
            Console.WriteLine("Iveskite 2: Pradekite nauja zaidima! ");
            Console.WriteLine("----------------++++++++++++++----------------");
        }

        public void DisplayHangman(int guessCount,string word ,List<char> guessed, List<char> correct)
        {
            _pictureFactory.DisplayPicture(guessCount, word,guessed, correct);
        }
    }
}
