using Microsoft.AspNetCore.Identity;
using System;

namespace SchoolRegister.Model.DataModels
{
    public class Grade
    {
        public Student Student{ get; set; }
        public GradeScale GradeValue{ get; set; }
        public DateTime DateOfissue {get; set;}
        public int StudentId  { get; set; }
        public int SubjectId  { get; set; }
        public Subject Subject{get; set;}
    }
}