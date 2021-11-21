using SchoolRegister.ViewModels.VM;
using SchoolRegister.Model.DataModels;
using System.Linq.Expressions;
using System.Collections.Generic;
using System;

namespace SchoolRegister.Services.Interfaces
{
    public interface ISubjectService
    {
        SubjectVm AddOrUpdateSubject(AddOrUpdateSubjectVM addOrUpdateVm);
        SubjectVm GetSubject(Expression<Func<Subject, bool>> filterExpression);
        IEnumerable<SubjectVm> GetSubjects(Expression<Func<Subject, bool>> filterExpression = null);
    }
}