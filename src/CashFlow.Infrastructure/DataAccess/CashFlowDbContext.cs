using CashFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CashFlow.Infrastructure.DataAccess;
internal class CashFlowDbContext : DbContext
{
    public DbSet<Expense> Expenses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Server=localhost;Database=cashflowdb;Uid=admin;Pwd=@password123;";

        var version = new Version(8, 4, 0);
        var serverVersion = new MySqlServerVersion(version);

        optionsBuilder.UseMySql(connectionString, serverVersion);
    }
}
