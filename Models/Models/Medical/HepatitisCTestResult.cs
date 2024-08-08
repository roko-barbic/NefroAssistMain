using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Models.Models.Enums;

namespace Models.Models.Medical;

public class HepatitisCTestResult
{
    [Key]
    public int Id { get; set; }
    public HepatitisCMarkers Marker { get; set; }
    public bool Result { get; set; }
    public int PatientId { get; set; }
    [ForeignKey("PatientId")] 
    public Patient.Patient Patient { get; set; }
}