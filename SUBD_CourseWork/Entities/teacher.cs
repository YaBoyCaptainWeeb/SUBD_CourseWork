
using System;
using System.Collections.Generic;
using System.Windows.Documents;

namespace SUBD_CourseWork.Entities
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string? HomeAdress { get; set; }
        public string? Contact { get; set; }


        public int? FacultyId { get; set; }
        public Faculty? Faculty { get; set; }
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }
        public int? JobTitleId { get; set; }
        public JobTitle? JobTitle { get; set; }
        public int? TypeOfCooperationId { get; set; }
        public TypeOfCooperation? TypeOfCooperation { get; set; }
        public int? DegreeId { get; set; }
        public Degree? Degree { get; set; }
        public int? AcademicRankId { get; set; }
        public AcademicRank? AcademicRank { get; set; }
        public int? InstitutionId { get; set; }
        public Institution? Institution { get; set;}

        


    }
}
