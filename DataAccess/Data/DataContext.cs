using Microsoft.EntityFrameworkCore;
using  Microsoft.Extensions.Configuration;
using Models.Models.Medical;
using Models.Models.Patient;
using Models.Models.Staff;

namespace DataAccess.Data;

public class DataContext : DbContext
{
    protected readonly IConfiguration Configuration;
    
    public DataContext(DbContextOptions<DataContext> options, IConfiguration configuration) : base(options)
    {
        Configuration = configuration;
    }
    
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<LaboratoryAnalysis> LaboratoryAnalyses { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development")
        {
            options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
        }
        else
        {
            options.UseNpgsql(Environment.GetEnvironmentVariable("POSTGRESQLCONNSTR_WebApiDatabase"));
        }
    }
    
}