using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUBD_CourseWork.Entities
{
    public class AcademicRank
    {
        public int Id { get; set; }
        public AcademicRankType AcademicRankType { get; set; }

        public DateTime YearOfAward { get; set; }

        public List<Teacher> Teachers { get; set; } = new();
    }
}
