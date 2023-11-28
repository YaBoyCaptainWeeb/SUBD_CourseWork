using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUBD_CourseWork.Entities
{
    public class ContactData
    {
        public int Id { get; set; }
        public List<EmailAdress> EmailAdresses { get; set; } = new();
        public List<PhoneNumber> PhoneNumbers { get; set; } = new();
    }
}
