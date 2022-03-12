using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SchoolRegister.Model
{
    public class Role: IdentityRole<int>
    {
        public Role() {}
        public Role(string name, RoleValue roleValue) {
            this.Name = name;
            this.RoleValue = roleValue;
        }
        public RoleValue RoleValue { get; set; }
    }
}