using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace SchoolRegister.Model.DataModels
{
    public class Role : IdentityRole<int>       
    {
        public RoleValue RoleValue { get; set; }
        public Role() { }
        public Role(string name, RoleValue roleValue)
        {
            this.Name = name;
            this.RoleValue = roleValue;
        }

    }
}