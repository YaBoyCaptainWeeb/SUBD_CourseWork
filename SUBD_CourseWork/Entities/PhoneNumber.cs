using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUBD_CourseWork.Entities
{
    public class PhoneNumber
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

    }
}
