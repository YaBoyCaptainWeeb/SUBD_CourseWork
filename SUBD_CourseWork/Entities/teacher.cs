﻿
using System;
using System.Collections.Generic;
using System.Windows.Documents;

namespace SUBD_CourseWork.Entities
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime DateOfBeginning { get; set; }
        public DateTime? DateOfEnding { get; set; }
        public double Wage { get; set; }
        public DateTime ElectedDate { get; set; }

        public int HouseNumberId { get; set; }
        public HouseNumber HouseNumber { get; set; }

        public List<PhoneNumber> PhoneNumbers { get; set; }
        public List<EmailAdress> EmailAdresses { get; set; }

        public int DepartmentId { get; set; }
        
        public Department Department { get; set; }
        
        public int JobTitleId { get; set; }
        public JobTitle JobTitle { get; set; }
        public int TypeOfCooperationId { get; set; }
        public TypeOfCooperation TypeOfCooperation { get; set; }
        
        public int DegreeId { get; set; }
        public Degree Degree { get; set; }
        
        public int AcademicRankId { get; set; }
        public AcademicRank AcademicRank { get; set; }

        public IndividualPlan IndividualPlan { get; set; }
    }
}
