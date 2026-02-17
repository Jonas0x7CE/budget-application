namespace BudgetApplication.Models.Budget;

public class BudgetCategory
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    
    public Guid BudgetId { get; set; }
    public Budget Budget { get; set; }
    public ICollection<BudgetItem> BudgetItems { get; set; } = new List<BudgetItem>();
}