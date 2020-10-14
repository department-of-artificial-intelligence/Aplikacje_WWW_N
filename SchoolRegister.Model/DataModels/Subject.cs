using Microsoft.AspNetCore.Identity;
using System;

namespace SchoolRegister.Model.DataModels
{
    public class Subject
    {
        public string Description{ get; set; }
        public string Name{ get; set; }
        public Teacher Teacher {get; set;}
        public List<Grade> Grades{get; set;}
        public int Id{get; set;}
        public int TeacherId{get; set;}
        public List<SubjectGroup> SubjectGroups{get; set;}
    }
}