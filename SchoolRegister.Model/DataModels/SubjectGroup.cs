using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace SchoolRegister.Model.DataModels{

    public class SubjectGroup{

        public Group Group {get; set;}

        public int GroupID{get; set;}

        public Subject Subject {get; set;}

        public int SubjectId {get; set;}
    }

}