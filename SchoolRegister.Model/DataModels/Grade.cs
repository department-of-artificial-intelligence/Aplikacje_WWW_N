using Microsoft.AspNetCore.Identity;
using System;
namespace SchoolRegister.Model.DataModels
{
    public class Grade
    {
        public DateTime DataOfissue { get; set; }
        public GradeScale Grandevalue { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
        public Subject Subject { get; set; }
        public int SubjectId { get; set; }
    }
}