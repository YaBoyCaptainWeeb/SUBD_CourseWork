using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUBD_CourseWork.Entities
{
    public class Degree
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? ShortName { get; set; }
        public string YearOfAward { get; set; }

        public int DisciplineCode { get; set; }

        public Discipline? Discipline { get; set; }

        public List<Teacher> Teachers { get; set; } = new();
    }
}
