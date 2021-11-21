using AutoMapper;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using SchoolRegister.DAL.EF;
using SchoolRegister.Model.DataModels;
using SchoolRegister.Services.interfaces;
using SchoolRegister.ViewModels.VM;

namespace SchoolRegister.Services.Services

{

    public class SubjectService : BaseService, ISubjectService
    {
        public SubjectService(ApplicationDbContext dbContext, IMapper mapper, ILogger logger) : base(dbContext, mapper, logger)
        {
        }

        public SubjectVm AddOrUpdateSubjectVm(AddOrUpdateSubjectVm addOrUpdateVm)
        {
            throw new NotImplementedException();
        }

        public SubjectVm GetSubject(Expression<Func<Subject, bool>> filterExpression)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SubjectVm> GetSubjects(Expression<Func<Subject, bool>> filterExpression = null)
        {
            throw new NotImplementedException();
        }
    }
}
