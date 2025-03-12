namespace Brain_Tumor_Classification.Models;

public class MedicalRecord
{
    [Key]  
    public int Id { get; set; }

    [Required]  
    [MaxLength(255)]  
    public string MRIImage { get; set; } = string.Empty;

    [Required]  
    public Tumor Tumor { get; set; } = default!;
}
