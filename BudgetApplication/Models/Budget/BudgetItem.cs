namespace BudgetApplication.Models.Budget;

public class BudgetItem
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    
    public Guid BudgetCategoryId { get; set; }
    public BudgetCategory BudgetCategory { get; set; }
}