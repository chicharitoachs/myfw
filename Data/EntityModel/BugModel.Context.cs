﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data.EntityModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BugEntities : DbContext
    {
        public BugEntities()
            : base("name=BugEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BugType> BugTypes { get; set; }
        public virtual DbSet<Priority> Priorities { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<StatusToStatu> StatusToStatus { get; set; }
        public virtual DbSet<Board> Boards { get; set; }
        public virtual DbSet<BugDetail> BugDetails { get; set; }
        public virtual DbSet<Bug> Bugs { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<GroupMapRole> GroupMapRoles { get; set; }
        public virtual DbSet<GroupUser> GroupUsers { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserMapRole> UserMapRoles { get; set; }
    }
}
