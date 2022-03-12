using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegister.Model
{
    public class Teacher: User
    {
        public IList<Subject> Subject { get; set; }
        public string Title { get; set; }
    }
}