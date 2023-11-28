using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUBD_CourseWork.Entities
{
    public class EmailAdress
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public int ContactDataId { get; set; }
        public ContactData ContactData { get; set; } = new();
    }
}
