using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SchoolRegister.Model.DataModels
{
    public class Group
    {
        [Key]
        public int Id {get; set;}
        public string Name {get; set;}
        public virtual IList <Student> Student {get; set;}
        public virtual IList <SubjectGroup> SubjectGroups {get; set;}
        
    }
}