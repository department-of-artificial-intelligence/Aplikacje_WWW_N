using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System;

namespace SchoolRegister.Model.DataModels
{
    public class Teacher : User
    {
        public IList <Subject> Subjects { get; set; }

        public string Title { get; set; } 
    }
}