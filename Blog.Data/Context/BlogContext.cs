﻿using Blog.Data.Enums;
using Blog.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Blog.Data.Context
{
   public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options): base(options)
        {
        }
        //tabloları veri tabanı için oluşturmak için bu kısımda tanıtıyoruz
        public DbSet <User> Users { get; set; }
        public DbSet<Blog.Data.Models.Blog> Blogs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Page> Pages { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Site> Sites { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                Id=1,
                CreateDate=DateTime.UtcNow,
                Deleted=false,
                Name="Aşk",
                Description="..."
            
                }
                );
            modelBuilder.Entity<Category>().HasData(
               new Category()
               {
                   Id = 2,
                   CreateDate = DateTime.UtcNow,
                   Deleted = false,
                   Name = "Meşk",
                   Description = "!!!!"

               }
               );

            modelBuilder.Entity<Nationality>().HasData(
                  new Nationality()
                  {
                      Id = 1,
                      CreateDate = DateTime.UtcNow,
                      Deleted = false,
                      Name = "Türkiye",
                      Code = "Tr",
                      
            


                 });

            modelBuilder.Entity<User>().HasData(
      new User()
     {
         Id = 1,
         CreateDate = DateTime.UtcNow,
         Deleted = false,
         Name = "Gözde",
         Username="gozde",
         Surname = "Yılmaz",
         Email="gozdecanki@gmail.com",
         Password="12345678",
         BirthDate= new DateTime(1992,12,11),
         Gender =Gender.Male,
         NationalityId=1


     });
            modelBuilder.Entity<Site>().HasData(new Site()
            {
                Id=1,
                Title="Gözde Cankı Erdoğan",
                Description="benim blogum",
                Slogan="Sayfama hoşgeldiniz",
                Copyright="İçerik hırsızlığına hayır"
            });



            base.OnModelCreating(modelBuilder);
        }
    }
}
