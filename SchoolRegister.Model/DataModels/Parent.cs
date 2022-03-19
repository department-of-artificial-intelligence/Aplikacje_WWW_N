using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System;
namespace SchoolRegister.Model.DataModels
{
    public class Parent : User
    {
        public IList<Student> Student { get; set; }
    }
}