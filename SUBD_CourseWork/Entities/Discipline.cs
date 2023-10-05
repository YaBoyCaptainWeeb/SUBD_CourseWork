using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUBD_CourseWork.Entities
{
    public class Discipline
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? ShortName { get; set; }

        public List<Degree> Degrees { get; set; } = new();
    }
}
