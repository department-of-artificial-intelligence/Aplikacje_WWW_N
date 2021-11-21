using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolRegister.Model.DataModels
{
    public class Student:User
    {
        [NotMapped]
        public double AverageGrade {get;}
        [NotMapped]
        public IDictionary<string,double> AverageGradePerSubject {get;}
        public virtual IList<Grade> Grades {get; set;}
        [NotMapped]
        public IDictionary<string,List<GradeScale>> GradesPerSubject {get;}
        public virtual Group Group {get;set;}
        public int? GroupId {get;set;}
        public virtual Parent Parent {get;set;}
        public int? ParentId {get;set;} 
    }
} 