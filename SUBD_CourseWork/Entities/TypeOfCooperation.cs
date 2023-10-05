using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUBD_CourseWork.Entities
{
    public class TypeOfCooperation
    {
        public int Id { get; set; }
        public bool State { get; set; }
        public bool Combined { get; set; }

        public List<Teacher> Teachers { get; set; } = new();
    }
}
