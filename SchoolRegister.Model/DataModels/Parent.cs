using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Collections;

namespace SchoolRegister.Model.DataModels
{
    public class Parent : User
    {
        public IList<Student> Students { get; set; }
    }
}