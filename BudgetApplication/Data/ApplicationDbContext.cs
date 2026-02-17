using BudgetApplication.Data;
using BudgetApplication.Models.Budget;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BudgetApplication.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Budget> Budgets { get; set; }
    public DbSet<BudgetCategory> BudgetCategories { get; set; }
    public DbSet<BudgetItem> BudgetItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Budget>()
            .HasMany(b => b.BudgetCategories)
            .WithOne(bc => bc.Budget)
            .HasForeignKey(bc => bc.BudgetId);
        
        modelBuilder.Entity<Budget>()
            .HasMany(b => b.Users)
            .WithMany(u => u.MemberBudgets)
            .UsingEntity(j => j.ToTable("BudgetUsers"));
        
        modelBuilder.Entity<Budget>()
            .HasOne<ApplicationUser>(b => b.CreatedBy)
            .WithMany(u => u.CreatedBudgets)
            .HasForeignKey(b => b.CreatedById)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<BudgetCategory>()
            .HasMany(bc => bc.BudgetItems)
            .WithOne(bi => bi.BudgetCategory)
            .HasForeignKey(bi => bi.BudgetCategoryId);
    }
}