using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Data
{
    public class PlaygroundContext : DbContext
    {
        public DbSet<Tag> TagSet { get; set; }

        public DbSet<Expense> ExpenseSet { get; set; }

        public PlaygroundContext()
            : base("PlaygroundDb")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tag>()
            .HasMany(tag => tag.Expenses)
            .WithMany(exp => exp.Tags)
            .Map(m => m.MapLeftKey("Id")
            .MapRightKey("Id")
            .ToTable("TagToExpense"));
        }
    }
}
