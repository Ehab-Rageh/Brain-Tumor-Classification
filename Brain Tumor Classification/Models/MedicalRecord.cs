namespace Brain_Tumor_Classification.Models;

public class MedicalRecord
{
    public int Id { get; set; }
    public string MRIImage { get; set; } = string.Empty;
    public int UserId { get; set; }
    public User User { get; set; } = default!;
    public Tumor Tumor { get; set; } = default!;
}
