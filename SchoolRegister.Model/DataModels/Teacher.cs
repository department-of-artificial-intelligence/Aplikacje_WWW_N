using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System;
namespace SchoolRegister.Model.DataModels
{
    public class Teacher : User
    {
        public IList<Subject> Subject { get; set; }
        public string Title { get; set; }
    }
}