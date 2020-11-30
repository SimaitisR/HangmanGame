using HangmanGame.DL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace HangmanGame.DL
{
    class KartuvesDbInitializer : CreateDatabaseIfNotExists<KartuvesDbContext>
    {
        protected override void Seed(KartuvesDbContext context)
        {
            List<Word> vardaiList = new List<Word>();
            List<Word> gyvunaiList = new List<Word>();
            List<Word> miestaiList = new List<Word>();
            List<Word> valstybesList = new List<Word>();

            Subject vardai = new Subject()
            {
                Name = "Vardai",
                Words = vardaiList
            };
            Subject gyvunai = new Subject()
            {
                Name = "Gyvunai",
                Words = gyvunaiList
            };
            Subject miestai = new Subject()
            {
                Name = "Miestai",
                Words = miestaiList
            };
            Subject valstybes = new Subject()
            {
                Name = "Valstybes",
                Words = valstybesList
            };

            context.Subjects.Add(vardai);
            context.Subjects.Add(gyvunai);
            context.Subjects.Add(miestai);
            context.Subjects.Add(valstybes);

            context.Words.Add(new Word()
            {
                Name = "RIMANTAS",
                Subject = vardai,
                SubjectId = vardai.Id,
            });
            context.Words.Add(new Word()
            {
                Name = "ARUNAS",
                Subject = vardai,
                SubjectId = vardai.Id,
            });
            context.Words.Add(new Word()
            {
                Name = "GRIEDRIUS",
                Subject = vardai,
                SubjectId = vardai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "RIMVYDAS",
                Subject = vardai,
                SubjectId = vardai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "RAMUNAS",
                Subject = vardai,
                SubjectId = vardai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "ALGIRDAS",
                Subject = vardai,
                SubjectId = vardai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "SARUNAS",
                Subject = vardai,
                SubjectId = vardai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "ARVYDAS",
                Subject = vardai,
                SubjectId = vardai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "JUOZAPAS",
                Subject = vardai,
                SubjectId = vardai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "GINTAUTAS",
                Subject = vardai,
                SubjectId = vardai.Id,


            });

            context.Words.Add(new Word()
            {
                Name = "SIKSNOSPARNIS",
                Subject = gyvunai,
                SubjectId = gyvunai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "ANTILOPE",
                Subject = gyvunai,
                SubjectId = gyvunai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "ORANGUTANGAS",
                Subject = gyvunai,
                SubjectId = gyvunai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "SIMPANZE",
                Subject = gyvunai,
                SubjectId = gyvunai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "TIGRAS",
                Subject = gyvunai,
                SubjectId = gyvunai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "DRAMBLYS",
                Subject = gyvunai,
                SubjectId = gyvunai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "ASILAS",
                Subject = gyvunai,
                SubjectId = gyvunai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "KIAULE",
                Subject = gyvunai,
                SubjectId = gyvunai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "KROKODILAS",
                Subject = gyvunai,
                SubjectId = gyvunai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "BEBRAS",
                Subject = gyvunai,
                SubjectId = gyvunai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "MESKENAS",
                Subject = gyvunai,
                SubjectId = gyvunai.Id,


            });

            context.Words.Add(new Word()
            {
                Name = "LIETUVA",
                Subject = valstybes,
                SubjectId = valstybes.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "ANGLIJA",
                Subject = valstybes,
                SubjectId = valstybes.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "PRANCUZIJA",
                Subject = valstybes,
                SubjectId = valstybes.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "SLOVAKIJA",
                Subject = valstybes,
                SubjectId = valstybes.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "LENKIJA",
                Subject = valstybes,
                SubjectId = valstybes.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "ESTIJA",
                Subject = valstybes,
                SubjectId = valstybes.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "LATVIJA",
                Subject = valstybes,
                SubjectId = valstybes.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "SUOMIJA",
                Subject = valstybes,
                SubjectId = valstybes.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "NORVEGIJA",
                Subject = valstybes,
                SubjectId = valstybes.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "SVEDIJA",
                Subject = valstybes,
                SubjectId = valstybes.Id,


            });

            context.Words.Add(new Word()
            {
                Name = "KAUNAS",
                Subject = miestai,
                SubjectId = miestai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "VILNIUS",
                Subject = miestai,
                SubjectId = miestai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "KLAIPEDA",
                Subject = miestai,
                SubjectId = miestai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "PANEVEZYS",
                Subject = miestai,
                SubjectId = miestai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "UTENA",
                Subject = miestai,
                SubjectId = miestai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "SILUTE",
                Subject = miestai,
                SubjectId = miestai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "VIEVIS",
                Subject = miestai,
                SubjectId = miestai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "RAMYGALA",
                Subject = miestai,
                SubjectId = miestai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "SILALE",
                Subject = miestai,
                SubjectId = miestai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "SIAULIAI",
                Subject = miestai,
                SubjectId = miestai.Id,


            });
            var word = new Word()
            {
                Name = "SIAULIAI",
                Subject = miestai,
                SubjectId = miestai.Id,
            };
            User user = new User()
            {
                Name = "Tester",
            };
            ScoreBoard sb = new ScoreBoard() {
                Time = DateTime.UtcNow,
                Word = word,
                WordToGuess = word.Name,
                User = user,
                IsCorrect = true,
                GuessCount = 2
            };

            context.ScoreBoards.Add(sb);

            context.Users.Add(user);
        }
    }
}
