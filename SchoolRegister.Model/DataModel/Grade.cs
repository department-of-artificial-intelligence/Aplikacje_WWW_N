using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolRegister.Model.DataModels
{
    public class Grade {
        public int Id {get; set;}
        [Required]
        public DateTime DateOfIssue {get; set;}
        [Required]
        public GradeScale GradeValue {get;set;}
        public virtual Student Student {get; set;}
        public int StudentId {get; set;}
        public virtual Subject Subject {get;set;}
        public int SubjectId {get; set;}
         
    }
}