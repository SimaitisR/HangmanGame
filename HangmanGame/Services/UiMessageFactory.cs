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
        public virtual void DisplaySubjects()
        {

        }
    }
}
