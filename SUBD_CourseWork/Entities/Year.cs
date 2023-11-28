using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUBD_CourseWork.Entities
{
    public class Year
    {
        public int Id { get; set; }
        public DateTime startOfYear { get; set; }
        public DateTime endOfYear { get; set; }

        public IndividualPlan individualPlans { get; set; }
    }
}
