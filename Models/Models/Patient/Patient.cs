using System.ComponentModel.DataAnnotations;
using Models.Models.Enums;
using Models.Models.Medical;

namespace Models.Models.Patient;

public class Patient
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime DateOfBirth { get; set; }
    public String? CityAddress { get; set; }
    public String? StreetAddress { get; set; }
    public String Diagnosis { get; set; }
    public String FirstHemodialysis { get; set; }
    public BloodType BloodType { get; set; }
    public RhFactor RhFactor { get; set; }
    public ICollection<HepatitisBTestResult> HepatitisBTestResults { get; set; }
    public ICollection<HepatitisCTestResult> HepatitisCTestResults { get; set; }
}