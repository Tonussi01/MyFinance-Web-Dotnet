using Microsoft.EntityFrameworkCore;
using Myfinance_web_dotnet.Domain;

namespace MyFinance_web_dotnet.Infrastruture{

    public class MyFinanceDbContext : DbContext
    {
        public DbSet<PlanoConta>PlanoConta {get; set;}  
        public DbSet<Transacao>Transacao {get; set;}   
    

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
    {
       var connectionString = @"Server=DESKTOP-9P877TA;Database=MyFinance;Trusted_Connection=True;TrustServerCertificate=True;";

        optionsBuilder.UseSqlServer(connectionString);
    }

    }

}