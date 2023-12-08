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
        public string DegreeType { get; set; }
        public DateOnly YearOfAward { get; set; }

        public int DisciplineId { get; set; }

        public Discipline Discipline { get; set; }

        public Teacher Teacher { get; set; }
    }
}
