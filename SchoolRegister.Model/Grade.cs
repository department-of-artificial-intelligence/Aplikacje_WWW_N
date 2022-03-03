using System;

namespace SchoolRegister.Model{
    public class Grade{
        public DateTime Date {get;set;}
        public GradeScale GradeValue {get;set;}
        public Subject Subject {get;set;}
        public int SubjectId {get;set;}
        public int StudentId {get;set;}
        public Student Student {get;set;}
    }
}