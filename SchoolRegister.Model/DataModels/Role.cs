using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System;

namespace SchoolRegister.Model.DataModels
{
    public class Role : IdentityRole <int>
    {
        public virtual RoleValue RoleValue { get; set; }

        public Role()
        {

        }

        public Role(string name, RoleValue roleValue)
        {

        }
    }
}