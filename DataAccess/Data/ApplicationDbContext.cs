using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace DataAccess.Data;


public class ApplicationDbContext : IdentityDbContext<IdentityUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
         //ovo je bilo prazno
    }
    // tu sad ide tipa: public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        
        // modelBuilder.Entity<Company>().HasData(
        //     new
        //     {
        //         Id = 1,
        //         Name = "IVS",
        //         State = "HRV",
        //         StreetAddress ="Vukovarska",
        //         City = "Osijek",
        //         PostalCode = "31000",
        //         PhoneNumber ="0191412412"
        //     }
        //    );
    }
}
