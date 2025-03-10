namespace Brain_Tumor_Classification.Models;

public class Tumor
{
    public int Id { get; set; }
    public bool HasTumor { get; set; } = false;
    public string TumorType { get; set; } = string.Empty;
    public int MedicalRecordId { get; set; }
    public MedicalRecord MedicalRecord { get; set; } = default!;
}
