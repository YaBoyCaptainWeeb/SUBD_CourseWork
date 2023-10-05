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

        public List<Teacher> Teachers { get; set; } = new();

    }
}
