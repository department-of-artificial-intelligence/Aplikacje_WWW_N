using Microsoft.AspNetCore.Identity;
using System;

namespace SchoolRegisterr.Model.DataModels
{
    public class User : IdentityUser<int>
    {
       
       public string FirstName { get; set;}
        
       public string LastName { get; set;}
        
       public DateTime RegistarionDate { get; set;} 
    }
}