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
        DateOnly yearOfAward;

        Faker<Street> _streetsFaker = null;
        Faker<HouseNumber> _houseNumbersFaker = null;
        Faker<EmailAdress> _emailAdressFaker = null;
        Faker<PhoneNumber> _phoneNumberFaker = null;
        Faker<AcademicRank> _academicRankFaker = null;
        Faker<Degree> _degreeFaker = null;
        Faker<Teacher> _teacherFaker = null;
        Faker<IndividualPlan> _individualPlanFaker = null;
        Faker<Year> _yearsFaker = null;
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
                .RuleFor(x => x.TeacherId, f => rnd.Next(1, teachersCount + 1));
            return _emailAdressFaker;
        }

        public Faker<PhoneNumber> GetPhoneNumberGenerator(int teachersCount) // Генератор номеров телефона
        {
            int id = 1;
            _phoneNumberFaker = new Faker<PhoneNumber>("ru")
                .UseSeed(1969)
                .RuleFor(x => x.Id, x => id++).RuleFor(x => x.Number, f => f.Phone.PhoneNumber())
                .RuleFor(x => x.TeacherId, f => rnd.Next(1,teachersCount + 1));
            return _phoneNumberFaker;
        }

        public Faker<AcademicRank> GetAcademicRankGenerator() // Генерация ученых званий
        {
            int id = 1;
            _academicRankFaker = new Faker<AcademicRank>("ru")
                .UseSeed(1969)
                .RuleFor(x => x.Id, x => id++).RuleFor(x => x.AcademicRankType, x => x.PickRandom<academicRanks>().ToString())
                .RuleFor(x => x.YearOfAward, x =>
                {
                    yearOfAward = x.Date.PastDateOnly(rnd.Next(15, 30), DateOnly.FromDateTime(DateTime.Now));
                    return yearOfAward;
                });
            return _academicRankFaker;
        }

        public Faker<Degree> GetDegreesGenerator() // Генерация ученых степеней
        {
            int id = 1;
            _degreeFaker = new Faker<Degree>("ru")
                .UseSeed(1969)
                .RuleFor(x => x.Id, x => id++).RuleFor(x => x.DegreeType, x => x.PickRandom(degreeTypes))
                .RuleFor(x => x.YearOfAward, f => yearOfAward.AddYears(rnd.Next(-6,-1)))
                .RuleFor(x => x.DisciplineId, x => rnd.Next(1,6));
            return _degreeFaker;
        }

        public Faker<Teacher> GetTeachersGenerator(int houseNumbersCount, int degreesCount) // возможно нужно доработать работу с датами: генерация ученых степеней
        {
            List<int> uniqueRandoms = GenerateUniqueRandomNumber(degreesCount);
            List<int> uniqueRandoms1 = GenerateUniqueRandomNumber(degreesCount);
            DateOnly beginningDateForTeacher = new DateOnly();
            int id = 1, i = 0,i1 = 0;
            _teacherFaker = new Faker<Teacher>("ru")
                .UseSeed(1969)
                .RuleFor(x => x.Id, x => id++).RuleFor(x => x.Surname, f => f.Name.LastName())
                .RuleFor(x => x.Name, f => f.Name.FirstName()).RuleFor(x => x.LastName, f => f.Name.LastName())
                .RuleFor(x => x.BirthDate, f =>
                {
                    beginningDateForTeacher = yearOfAward.AddYears(rnd.Next(-30,-21)).AddMonths(rnd.Next(-2, 6)).AddDays(rnd.Next(-15, 25));
                    return beginningDateForTeacher;
                    
                })
                .RuleFor(x => x.DateOfBeginning, f =>
                {
                    beginningDateForTeacher = yearOfAward.AddYears(rnd.Next(0,2)).AddMonths(rnd.Next(0,3)).AddDays(rnd.Next(0,16));
                   return beginningDateForTeacher;
                })
                .RuleFor(x => x.DateOfEnding, f => f.Date.PastDateOnly(rnd.Next(1, 4), DateOnly.FromDateTime(DateTime.Now)).OrNull(f, 0.90f))
                .RuleFor(x => x.Wage, f => rnd.Next(15, 65) * 1000)
                .RuleFor(x => x.ElectedDate, f =>
                {
                    DateOnly electedDate = beginningDateForTeacher;
                    return electedDate.AddMonths(rnd.Next(-3, -1));
                })
                .RuleFor(x => x.HouseNumberId, f => rnd.Next(1, houseNumbersCount + 1))
                .RuleFor(x => x.DepartmentId, f => rnd.Next(1, 32))
                .RuleFor(x => x.JobTitleId, f => rnd.Next(1, 8))
                .RuleFor(x => x.TypeOfCooperationId, f => rnd.Next(1, 3))
                .RuleFor(x => x.DegreeId, f =>
                {
                    int c = uniqueRandoms[i];
                    i++;
                    return c;
                })
                .RuleFor(x => x.AcademicRankId, f =>
                {
                    int c = uniqueRandoms1[i1];
                    i1++;
                    return c;
                });
            return _teacherFaker;
        }

        public Faker<IndividualPlan> GetIndividualPlanFaker(int teachersCount,int yearsCount)
        {
            int id = 1,i = 0;
            int buff = 0;
            List<int> uniqueRandom2 = GenerateUniqueRandomNumber(teachersCount);
            _individualPlanFaker = new Faker<IndividualPlan>("ru")
                .UseSeed(1969)
                .RuleFor(x => x.Id,f => id++)
                .RuleFor(x => x.TypeOfWorkId, f => rnd.Next(1, 8))
                .RuleFor(x => x.plannedForFallSemestre, f =>
                {
                    buff = rnd.Next(40, 171);
                    return buff;
                })
                .RuleFor(x => x.factForFallSemestre, f =>
                {
                    int c = rnd.Next(buff - 10, buff + 10);
                    return c;
                })
                .RuleFor(x => x.plannedForSpringSemestre, f =>
                {
                    buff = rnd.Next(40, 171);
                    return buff;
                })
                .RuleFor(x => x.factForSpringSemestre, f =>
                {
                    int c = rnd.Next(buff - 10, buff + 10);
                    return c;
                })
                .RuleFor(x => x.teacherId, f =>
                {
                    int c = uniqueRandom2[i];
                    i++;
                    return c;
                })
                .RuleFor(x => x.YearId, f => rnd.Next(1,yearsCount+1));
            return _individualPlanFaker;
        }

        public Faker<Year> GetYearGenerator(int yearsCount)
        {
            int id = 1, yearIndex = 1;
            DateOnly startOfYear = new DateOnly(2023,9,1);
            _yearsFaker = new Faker<Year>("ru")
                .UseSeed(1969)
                .RuleFor(x => x.Id, f => id++)
                .RuleFor(x => x.startOfYear, f =>
                {
                    startOfYear = f.Date.PastDateOnly(++yearIndex, startOfYear);
                    startOfYear = new DateOnly(startOfYear.Year, 9, 1);
                    return startOfYear;
                })
                .RuleFor(x => x.endOfYear, f =>
                {
                    DateOnly c = new DateOnly(startOfYear.AddYears(1).Year, 5, 30);
                    return c;
                });
            return _yearsFaker;
        }

        List<int> GenerateUniqueRandomNumber(int max)
        {
            List<int> result = new List<int>();
            Random rnd = new Random();
            while (result.Count != max)
            {
                int num = rnd.Next(1, max + 1);
                if (!result.Contains(num))
                {
                    result.Add(num);
                }
            }
            result.Add(0);
            return result;
        }
    }
}
