using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace SchoolRegisterr.Model.DataModels
{
    public class Teacher : User
    {
        public IList<Subject> Subjects {get; set;}
    }
}
