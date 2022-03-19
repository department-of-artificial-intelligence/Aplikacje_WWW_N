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

        public ApplicationDbContext (DbContextOption <ApplicationDbContext> options)
        :base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionBuilder){
            base.OnConfiguring(optionsBuilder);
            //configuration command
            optionsBuilder.User.LazyLoadingProxiex(); //enable lazy loading proxies
        }

        protected ovveride void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            //fluent API commands

            modelBuilder.Entity<User>()
            .ToTable("AspNetUser")
            .HasDiscriminator<int>("UserType")
            .HasValue<User>((int)RoleValue.User)
            .Has<Student>((int)RoleValue.Student)
            .Has<Parent>((int)RoleValue.Parent)
            .HasValue<Teacher>((int)RoleValue.Teacher);
        }

    }

}