using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUBD_CourseWork.Entities
{
    public class Faculty
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string? ShortName { get; set; }
        public int InstitutionId { get; set; }
        public Institution Institution { get; set; }

        public List<Department>? Departments { get; set; } = new();
        //public List<Teacher> Teachers { get; set; } = new();

    }
}
