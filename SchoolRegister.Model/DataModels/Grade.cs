using Microsoft.AspNetCore.Identity;
using SchoolRegister.Model.DataModels;
using System;
using System.Collections.Generic;

namespace SchoolRegisterr.Model.DataModels
{
    public class Grade
    {
        public DateTime DateOfIssue {get; set;}
        public GradeScale GradeValue {get; set;}
        public Student Student {get; set;}
        public int StudentId {get; set;}
        public Subject Subject {get; set;}
        public int SubjectId {get; set;}
    }
}
