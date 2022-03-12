using Microsoft.AspNetCore.Identity;
using SchoolRegister.Model.DataModels;
using System;
using System.Collections.Generic;

namespace SchoolRegisterr.Model.DataModels
{
    public class Student : User
    {
        public double AverageGrade {get;}

        public IDictionary <string, double> AVerageGradePerSubject {get;}

        public IList<Grade> Grades{get; set;}
        public IDictionary<string, List<GradeScale>> GradesPerSubject {get;}

        public Group Group {get; set;}

        public int?  GroupId {get; set;}

        public Parent Parent {get; set;}

        public int? ParentId {get; set;}
    }
}