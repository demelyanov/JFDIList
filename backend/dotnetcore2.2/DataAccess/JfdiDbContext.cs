using JFDIList.Domain.Model;
using JFDIList.Domain.Model.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JFDIList.DataAccess
{
    public class JfdiDbContext : IdentityDbContext<JfdiUser, JfdiRole, int>
    {
        public JfdiDbContext(DbContextOptions<JfdiDbContext> options) : base(options)
        {
        }

        public DbSet<Tag> Tags { get; set; }
        public DbSet<TaskItem> Tasks { get; set; }
        public DbSet<TaskList> Lists { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<TaskTag>()
                .HasKey(tt => new { tt.TaskId, tt.TagId });

            builder.Entity<TaskTag>()
                .HasOne(tt => tt.Task)
                .WithMany(t => t.TagsTask)
                .HasForeignKey(tt => tt.TaskId);

            builder.Entity<TaskTag>()
                .HasOne(t => t.Tag)
                .WithMany(tt => tt.TasksTag)
                .HasForeignKey(t => t.TagId);
        }
    }
}
