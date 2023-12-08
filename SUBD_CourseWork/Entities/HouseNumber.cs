using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUBD_CourseWork.Entities
{
    public class HouseNumber
    {
        public int Id { get; set; }
        public int House { get; set; }
        public int StreetId { get; set; }
        public Street street { get; set; }
        public List<Teacher> Teachers { get; set; } = new();
    }
}
