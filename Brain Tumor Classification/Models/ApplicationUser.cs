namespace Brain_Tumor_Classification.Models;

public class ApplicationUser : IdentityUser
{
    [Required]
    [MaxLength(100)]  
    public string Name { get; set; }

    [Required]
    [MaxLength(10)]  
    public string Gender { get; set; }

    [Required]
    [DataType(DataType.Date)]  
    public DateTime BirthDate { get; set; }

    public virtual ICollection<MedicalRecord> MedicalRecords { get; set; } = new List<MedicalRecord>();
}

