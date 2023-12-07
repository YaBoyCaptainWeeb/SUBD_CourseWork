using System;
using System.Collections.Generic;
using System.Linq;
using Bogus;
using System.Text;
using System.Threading.Tasks;
using SUBD_CourseWork.Entities;

namespace SUBD_CourseWork
{
    public class Fakers
    {
        Faker<Street> _streetsFaker = null;

        public Faker<Street> GetStreetsGenerator()
        {
            if (_streetsFaker == null)
            {
                var id = 0;
                _streetsFaker = new Faker<Street>()
                    .RuleFor(x => x.Id, x => id++).RuleFor(x => x.Name, x => x.Address.StreetName());
            }
        }
    }
}
