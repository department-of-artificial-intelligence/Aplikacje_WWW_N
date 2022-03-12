using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
namespace SchoolRegister.Model.DataModels
{
    public class Group
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public IList <Student> Student {get; set;}
        public IList <SubjectGroup> SubjectGroups {get; set;}
        
    }
}