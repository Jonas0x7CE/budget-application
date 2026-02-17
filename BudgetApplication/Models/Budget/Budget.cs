using BudgetApplication.Data;

namespace BudgetApplication.Models.Budget;

public class Budget
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Year { get; set; }

    public string CreatedById { get; set; }
    public ApplicationUser CreatedBy { get; set; }
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.Now;
    
    public ICollection<BudgetCategory> BudgetCategories { get; set; }
    public ICollection<ApplicationUser> Users { get; set; }
}