namespace TaskManagementApp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TaskDb : DbContext
    {
        public TaskDb()
            : base("name=TaskDb")
        {
        }

        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<task> tasks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<employee>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.middle_name)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .HasMany(e => e.tasks)
                .WithOptional(e => e.employee)
                .HasForeignKey(e => e.task_assignee);

            modelBuilder.Entity<task>()
                .Property(e => e.task_name)
                .IsUnicode(false);

       
        }
    }
}
