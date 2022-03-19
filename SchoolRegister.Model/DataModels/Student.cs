using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolRegister.Model.DataModels
{
    public class Student : User
    {
        public virtual Group Grup { get; set; }
        [ForeignKey("Grup")]
        public int? GroupId { get; set; }
        public IList <Grade> Grades { get; set; }
        public Parent Parent { get; set; }

        [ForeignKey ("Parent")]
        public int? ParentId { get; set; }

        [NotMapped]
        public double AverageGrade => Grades == null || Grades.Count ==0 ? 0.0d : Math.Round(Grades.Average(g => (int)g.GradeValue), 1);

        [NotMapped]
        public IDictionary <string, double> AverageGradePerSubjects => Grades == null ? new Dictionary<string, double>() :
            Grades.GroupBy(g => g.Subject.Name).Select(g => new{ SubjectName = g.Key, AvgGrade = Math.Round(g.Average(AverageGrade => (int) AverageGrade.Grade.Value), 1)}).ToDictionary(avg => avg.SubjectNaame, avg => avg.AvgGrade);

        [NotMapped]
        public IDictionary <string, List<GradeScale>>  GradePerSubjects => Grades == null ? new Dictionary<string, List<GradesScale>>() : Grades.GroupBy(g = g.SubjectName).Select(g => new {SubjectName = g.Key, GrtadeList = g.Select (x=>x.GradeValue).ToList()}).ToDictionary(x=>x.SubjectName, x=>x.GradeList);


        //public double AverageGrade { get; }

        //public IDictionary <string, double> AverageGradePerSubjects { get; }

        //public IDictionary <string, List<GradeScale>> GradePerSubjects { get; }

        // 

    }
}