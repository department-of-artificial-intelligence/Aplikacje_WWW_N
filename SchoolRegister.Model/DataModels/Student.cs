using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace SchoolRegister.Model.DataModels{

    public class Student:User{

        public double AverageGrade {get;}

        public IDictionary<string,double> AverageGradePerSubject {get;}

        public IList<Grade> Grades{get; set;}

        public IDicttionary<string, List<GradeScale>> GradesPerSubject{get;}

        public Group Group {get; set;}

        public int Groupld {get; set;}

        public Parent Parent {get; set;}

        public int Parentld {get; set;}


    }


}