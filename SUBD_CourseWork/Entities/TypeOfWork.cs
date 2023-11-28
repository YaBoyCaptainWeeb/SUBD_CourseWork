using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUBD_CourseWork.Entities
{
    public class TypeOfWork
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? ShortName { get; set; }
        public List<IndividualPlan> IndividualPlans = new();
    }
}
