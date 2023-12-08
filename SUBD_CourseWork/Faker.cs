using System;
using System.Collections.Generic;
using System.Linq;
using Bogus;
using System.Text;
using System.Threading.Tasks;
using SUBD_CourseWork.Entities;
using System.CodeDom.Compiler;
using Bogus.DataSets;

namespace SUBD_CourseWork
{
    public enum academicRanks
    {
        Доцент,
        Профессор    
    }

    public class Fakers
    {
        string[] degreeTypes = new string[2]
        {
            "Кандидат наук", "Доктор наук"
        };

        Faker<Street> _streetsFaker = null;
        Faker<HouseNumber> _houseNumbersFaker = null;
        Faker<EmailAdress> _emailAdressFaker = null;
        Faker<PhoneNumber> _phoneNumberFaker = null;
        Faker<AcademicRank> _academicRankFaker = null;
        Faker<Degree> _degreeFaker = null;
        // ДОДЕЛАТЬ ФЕЙКЕР
        Random rnd = new Random();

        public Faker<Street> GetStreetsGenerator() // Генератор улиц
        {
            int id = 1;
            _streetsFaker = new Faker<Street>("ru")
                .UseSeed(1969)
                    .RuleFor(x => x.Id, x => id++).RuleFor(x => x.Name, x => x.Address.StreetName());
            return _streetsFaker;
        }
        public Faker<HouseNumber> GetHouseNumberGenerator(int streetsCount) // Генератор домов
        {
            int id = 1;
            _houseNumbersFaker = new Faker<HouseNumber>("ru")
                .UseSeed(1969)
                .RuleFor(x => x.Id, x => id++).RuleFor(x => x.House, f => Convert.ToInt32(f.Address.BuildingNumber())/10)
                .RuleFor(x => x.StreetId, x => rnd.Next(1,streetsCount + 1));
            return _houseNumbersFaker;
        }
        public Faker<EmailAdress> GetEmailAdressGenerator(int teachersCount) // Генератор почтовых адресов
        {
            int id = 1;
            _emailAdressFaker = new Faker<EmailAdress>("ru")
                .UseSeed(1969)
                .RuleFor(x => x.Id, x => id++).RuleFor(x => x.Email, f => f.Internet.Email())
                .RuleFor(x => x.TeacherId, f => rnd.Next(1, teachersCount));
            return _emailAdressFaker;
        }

        public Faker<PhoneNumber> GetPhoneNumberGenerator(int teachersCount) // Генератор номеров телефона
        {
            int id = 1;
            _phoneNumberFaker = new Faker<PhoneNumber>("ru")
                .UseSeed(1969)
                .RuleFor(x => x.Id, x => id++).RuleFor(x => x.Number, f => f.Phone.PhoneNumber())
                .RuleFor(x => x.TeacherId, f => rnd.Next(1,teachersCount));
            return _phoneNumberFaker;
        }

        public Faker<AcademicRank> GetAcademicRankGenerator() // Генерация ученых званий
        {
            int id = 1;
            _academicRankFaker = new Faker<AcademicRank>("ru")
                .UseSeed(1969)
                .RuleFor(x => x.Id, x => id++).RuleFor(x => x.AcademicRankType, x => x.PickRandom<academicRanks>().ToString())
                .RuleFor(x => x.YearOfAward, x => x.Date.PastDateOnly(18,DateOnly.FromDateTime(DateTime.Now)));
            return _academicRankFaker;
        }

        public Faker<Degree> GetDegreesGenerator()
        {
            int id = 1;
            _degreeFaker = new Faker<Degree>("ru")
                .UseSeed(1969)
                .RuleFor(x => x.Id, x => id++).RuleFor(x => x.DegreeType, x => x.PickRandom(degreeTypes))
                .RuleFor(x => x.YearOfAward, x => x.Date.PastDateOnly(18,DateOnly.FromDateTime(DateTime.Now)))
                .RuleFor(x => x.DisciplineId, x => rnd.Next(1,6));
            return _degreeFaker;
        }

    }
}
