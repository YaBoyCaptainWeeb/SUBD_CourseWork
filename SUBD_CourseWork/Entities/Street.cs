using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUBD_CourseWork.Entities
{
    public class Street
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<HouseNumber> HouseNumbers { get; set; } = new();
    }
}
