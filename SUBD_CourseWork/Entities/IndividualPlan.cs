using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUBD_CourseWork.Entities
{
    public class IndividualPlan
    {
        public int Id { get; set; }
        
        public int TypeOfWorkId { get; set; }
        public TypeOfWork TypeOfWork { get; set; }
        
        public int plannedForFallSemestre { get; set; }
        public int plannedForSpringSemestre { get; set; }
        public int factForFallSemestre { get; set; }
        public int factForSpringSemestre { get; set; }

        public int teacherId { get; set; }
        public Teacher teacher { get; set; }

        public int YearId { get; set; }
        public Year Year { get; set; }
    }
}
