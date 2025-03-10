namespace Brain_Tumor_Classification.Models;

public class User
{
    public int Id { get; set; }
    public string FName { get; set; } = string.Empty;
    public string LName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; } = DateTime.Now;
    public IEnumerable<MedicalRecord> MedicalRecords { get; set; } = new List<MedicalRecord>();
}
