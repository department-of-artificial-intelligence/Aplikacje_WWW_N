using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SchoolRegister.Model.DataModels;
using SchoolRegister.ViewModels.VM;


namespace SchoolRegister.Services.interfaces
{

    public interface ISubjectService
    {
       SubjectVm AddOrUpdateSubjectVm (AddOrUpdateSubjectVm addOrUpdateVm);  
       SubjectVm GetSubject(Expression<Func<Subject,bool>> filterExpression);

       IEnumerable<SubjectVm> GetSubjects (Expression<Func<Subject,bool>> filterExpression=null);

    }
    
}
