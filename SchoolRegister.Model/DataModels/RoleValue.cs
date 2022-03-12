using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System;

namespace SchoolRegister.Model.DataModels
{
    public enum RoleValue
    {
        User = 1, 
        Student = 2,
        Parent = 3,
        Teacher = 4,
        Admin = 0,
    }
}