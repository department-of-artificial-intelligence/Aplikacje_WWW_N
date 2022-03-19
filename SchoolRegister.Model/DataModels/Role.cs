using Microsoft.AspNetCore.Identity;
using System;

namespace SchoolRegister.Model.DataModels
{
    public class Role : IdentityRole<int>
    {
        public RoleValue Rolevalue { get; set; }
        public Role(){}

        public Role(string name, RoleValue roleValue){
            Rolevalue=roleValue;
this.Name = name;
        }
    }
}