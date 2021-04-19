using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using zepllin.Models;
namespace zepllin.Database
{
    public class DatabaseContext : IdentityDbContext<CreateUsers>
    {
        #region Veritabanı Bağlantısı
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(GetConnString, new MySqlServerVersion(new Version(8, 0, 22)),mysopt => mysopt.CharSetBehavior(CharSetBehavior.NeverAppend)).EnableSensitiveDataLogging().EnableDetailedErrors();
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public virtual DbSet<Category> Category
        {
            get;
            set;
        }
        public virtual DbSet<UserImages> UserImages
        {
            get;
            set;
        }
        public virtual DbSet<Vote> Votes
        {
            get;
            set;
        }
        public virtual DbSet<Comments> Comments 
        {
            get;
            set;
        }
        /*Veritabanı bağlantı string*/
        public static string GetConnString
        {
            get
            {
                return "server=localhost;uid=root;password=951753;database=zepllin;Allow User Variables=True";
            }
        }
        #endregion
    }
}
