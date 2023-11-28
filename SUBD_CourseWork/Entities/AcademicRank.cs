using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUBD_CourseWork.Entities
{
    public class AcademicRank
    {
        public int Id { get; set; }
        public string AcademicRankType { get; set; }
        public DateTime YearOfAward { get; set; }

        public Teacher Teacher { get; set; }
    }
}
