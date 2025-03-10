namespace Brain_Tumor_Classification.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Tumor>Tumors { get; set; }
    public DbSet<MedicalRecord> MedicalRecords { get; set; }
}
