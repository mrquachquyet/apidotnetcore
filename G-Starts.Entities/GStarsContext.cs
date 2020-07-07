using System;
using G_Starts.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace G_Starts.Entities
{
    public partial class GStarsContext : DbContext
    {
        public GStarsContext()
        {
        }

        public GStarsContext(DbContextOptions<GStarsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Config> Config { get; set; }
        public virtual DbSet<SysFunction> SysFunction { get; set; }
        public virtual DbSet<SysFunctionGroupFunction> SysFunctionGroupFunction { get; set; }
        public virtual DbSet<SysGroupFunction> SysGroupFunction { get; set; }
        public virtual DbSet<SysMenuGroup> SysMenuGroup { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserFunction> UserFunction { get; set; }
        public virtual DbSet<UserGroupFunction> UserGroupFunction { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Type).HasComment("ADMIN, COLLECTOR, INVOICE, CUSTOMER");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
