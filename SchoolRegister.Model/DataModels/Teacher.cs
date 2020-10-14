using Microsoft.AspNetCore.Identity;
using System;

namespace SchoolRegister.Model.DataModels
{
    public class Teacher : User
    {
        public string Title{ get; set; }
        public List<Subject> Subjects{ get; set; }

    }
}