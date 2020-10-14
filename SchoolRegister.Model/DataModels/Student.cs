using Microsoft.AspNetCore.Identity;
using System;

namespace SchoolRegister.Model.DataModels
{
    public class Student : User
    {
        public double AverageGrade{ get; }
        public Dictionary<string,double> AverageGradePerSubject{get;}
        public Dictionary<string,List<GradeScale>> Grades{get; set;}
        public Group Group{get; set;}
        public int GroupId  { get; set; }
        public Parent Parent{get; set;}
        public int ParentId  { get; set; }
    }
}