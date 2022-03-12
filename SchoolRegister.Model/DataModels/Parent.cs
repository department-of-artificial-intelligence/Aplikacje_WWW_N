using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace SchoolRegisterr.Model.DataModels
{
    public class Parent : User
    {
        public IList<Student> Students {get; set;}
    }
}
