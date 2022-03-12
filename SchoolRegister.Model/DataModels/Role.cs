using Microsoft.AspNetCore.Identity;
using SchoolRegister.Model.DataModels;
using System;
using System.Collections.Generic;

namespace SchoolRegisterr.Model.DataModels
{
    public class Role : IdentityRole<int>
    {
        public RoleValue RoleValue {get; set;}

        public Role(string name, RoleValue roleValue){
            RoleValue = roleValue;
            this.Name = name;
        }
    }
}
    