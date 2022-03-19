using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolRegister.Model.DataModels;

namespace SchoolRegister.DAL.EF{

    public class ApplicationDbContext : IdentityDbContext <User,Role, int>{

        //table properties e.g
        // public virtual DbSet<Entity> TableName {get; set;}

        public virtual DbSet<Grade> Grades{get; set;}
        //more properties need to be added

        public ApplicationDbContext (DbContextOptions <ApplicationDbContext> options)
        :base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //configuration command
            optionsBuilder.UseLazyLoadingProxies();
               
         }
    

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            //fluent API commands

            modelBuilder.Entity<User>()
            .ToTable("AspNetUser")
            .HasDiscriminator<int>("UserType")
            .HasValue<User>((int)RoleValue.User)
            .HasValue<Student>((int)RoleValue.Student)
            .HasValue<Parent>((int)RoleValue.Parent)
            .HasValue<Teacher>((int)RoleValue.Teacher);
        }

    }

}