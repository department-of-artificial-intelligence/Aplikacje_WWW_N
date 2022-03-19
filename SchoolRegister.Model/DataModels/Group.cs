using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;


namespace SchoolRegister.Model.DataModels{

    public class Group{

        public int ID {get; set;}

        public string Name {get; set;}

        public IList<Student> Students {get; set;}
        
        public IList<SubjectGroup> SubjectGroups {get; set;}
    }




}