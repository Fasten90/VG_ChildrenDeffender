﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChildrenDeffenderWebAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ChildrenDeffenderEntities : DbContext
    {
        public ChildrenDeffenderEntities()
            : base("name=ChildrenDeffenderEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Category> Category { get; set; }
        public DbSet<IndexImage> IndexImage { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Sound> Sound { get; set; }
        public DbSet<User> User { get; set; }
    }
}