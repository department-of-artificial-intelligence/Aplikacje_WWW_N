using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Collections;

namespace SchoolRegister.Model.DataModels
{
    public class Role : IdentityRole<int>
    {
        public RoleValue RoleValue { get; set; }
        Role(){}
        Role(string name, RoleValue roleValue){}
    }
}