var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.BudgetApplication>("budget-application");

builder.AddNpmApp("budget-application-npm", @"..\BudgetApplication\", "tailwind:dev");

builder.Build().Run();