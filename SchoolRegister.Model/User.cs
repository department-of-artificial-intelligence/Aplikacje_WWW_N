using System;
using Microsoft.AspNetCore.Identity;

namespace SchoolRegister.Model
{
    public class User : IdentityUser<int> 
    {
        public string FristName {get;set;}
        public string LastName {get;set;}
        public DateTime RegistrationDate {get;set;}
    
    }
}
