using Microsoft.EntityFrameworkCore;
using ToDoList.Business.Models;

namespace ToDoList.Data.Context;

public class MeuDbContext : DbContext
{
    public MeuDbContext(DbContextOptions<MeuDbContext> options) : base(options)
    {
        
    }

    public DbSet<Pessoa> Pessoas { get; set; }
    public DbSet<Atividade> Atividades { get; set; }
    
    //Sobreescrevendo o OnModelCreating
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        foreach (var property  in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
        {
            property.SetColumnType("Varchar(100)");
        }

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeuDbContext).Assembly);

        foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
        {
            relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;
        }
        
        base.OnModelCreating(modelBuilder);
    }
}