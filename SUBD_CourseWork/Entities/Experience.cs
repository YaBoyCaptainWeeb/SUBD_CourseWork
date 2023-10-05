using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUBD_CourseWork.Entities
{
    public class Experience
    {
        public int Id { get; set; }
        public string DateOfBeginning { get; set; }
        public string DateOfEndning { get;set; }
        public int Wages { get; set; }
        public string ElectedDate { get; set; }
        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set;}
        public int JobTitleId { get; set; }
        public JobTitle? JobTitle { get; set; }
    }
}
