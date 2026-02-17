using BudgetApplication.Models.Budget;
using Microsoft.AspNetCore.Identity;

namespace BudgetApplication.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    // Navigation property for budgets created by the user
    public ICollection<Budget> CreatedBudgets { get; set; } = new List<Budget>();

    // Navigation property for budgets where the user is a member
    public ICollection<Budget> MemberBudgets { get; set; } = new List<Budget>();
}