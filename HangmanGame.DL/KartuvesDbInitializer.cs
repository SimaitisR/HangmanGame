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
                Name = "Rimantas",
                Subject = vardai,
                SubjectId = vardai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Arunas",
                Subject = vardai,
                SubjectId = vardai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Giedrius",
                Subject = vardai,
                SubjectId = vardai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Rimvydas",
                Subject = vardai,
                SubjectId = vardai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Ramunas",
                Subject = vardai,
                SubjectId = vardai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Algirdas",
                Subject = vardai,
                SubjectId = vardai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Sarunas",
                Subject = vardai,
                SubjectId = vardai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Arvydas",
                Subject = vardai,
                SubjectId = vardai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Juozapas",
                Subject = vardai,
                SubjectId = vardai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Gintautas",
                Subject = vardai,
                SubjectId = vardai.Id,


            });

            context.Words.Add(new Word()
            {
                Name = "Siksnosparnis",
                Subject = gyvunai,
                SubjectId = gyvunai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Antilope",
                Subject = gyvunai,
                SubjectId = gyvunai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Orangutangas",
                Subject = gyvunai,
                SubjectId = gyvunai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Simpanze",
                Subject = gyvunai,
                SubjectId = gyvunai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Tigras",
                Subject = gyvunai,
                SubjectId = gyvunai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Dramblys",
                Subject = gyvunai,
                SubjectId = gyvunai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Asilas",
                Subject = gyvunai,
                SubjectId = gyvunai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Kiaule",
                Subject = gyvunai,
                SubjectId = gyvunai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Krokodilas",
                Subject = gyvunai,
                SubjectId = gyvunai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Bebras",
                Subject = gyvunai,
                SubjectId = gyvunai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Meskenas",
                Subject = gyvunai,
                SubjectId = gyvunai.Id,


            });

            context.Words.Add(new Word()
            {
                Name = "Lietuva",
                Subject = valstybes,
                SubjectId = valstybes.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Anglija",
                Subject = valstybes,
                SubjectId = valstybes.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Prancuzija",
                Subject = valstybes,
                SubjectId = valstybes.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Slovakija",
                Subject = valstybes,
                SubjectId = valstybes.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Lenkija",
                Subject = valstybes,
                SubjectId = valstybes.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Estija",
                Subject = valstybes,
                SubjectId = valstybes.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Latvija",
                Subject = valstybes,
                SubjectId = valstybes.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Suomija",
                Subject = valstybes,
                SubjectId = valstybes.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Norvegija",
                Subject = valstybes,
                SubjectId = valstybes.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Svedija",
                Subject = valstybes,
                SubjectId = valstybes.Id,


            });

            context.Words.Add(new Word()
            {
                Name = "Kaunas",
                Subject = miestai,
                SubjectId = miestai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Vilnius",
                Subject = miestai,
                SubjectId = miestai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Klaipeda",
                Subject = miestai,
                SubjectId = miestai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Panevezys",
                Subject = miestai,
                SubjectId = miestai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Utena",
                Subject = miestai,
                SubjectId = miestai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Silute",
                Subject = miestai,
                SubjectId = miestai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Vievis",
                Subject = miestai,
                SubjectId = miestai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Ramygala",
                Subject = miestai,
                SubjectId = miestai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Silale",
                Subject = miestai,
                SubjectId = miestai.Id,


            });
            context.Words.Add(new Word()
            {
                Name = "Siauliai",
                Subject = miestai,
                SubjectId = miestai.Id,


            });
            var word = new Word()
            {
                Name = "Siauliai",
                Subject = miestai,
                SubjectId = miestai.Id,
            };
            User user = new User()
            {
                Name = "Tester",
            };
            ScoreBoard sb = new ScoreBoard() { 
                Time = DateTime.UtcNow,
                Word=word,
                User=user
            };

            context.ScoreBoards.Add(sb);

            context.Users.Add(user);
        }
    }
}
