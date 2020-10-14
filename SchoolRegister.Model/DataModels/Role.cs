using Microsoft.AspNetCore.Identity;
using System;

namespace SchoolRegister.Model.DataModels
{
    public class Role : IdentityRole<int>
    {
        public RoleValue RoleValue{ get; set; }
        public method Role();
        public method Role(string name,RoleValue rolevalue);
    }
}