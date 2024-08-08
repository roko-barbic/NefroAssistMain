using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using  Models.Models.Patient;


namespace Models.Models.Medical;

public class LaboratoryAnalysis
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public DateTime timeOfSampling { get; set; }
    public int PatientId { get; set; }
    [ForeignKey("PatientId")] 
    public Patient.Patient Patient { get; set; }
    
    //nalaz
    public int leukocytes { get; set; }  // x10na9/L
    public int erythrocytes { get; set; } // x10na9/L
    public double hemoglobin { get; set; } // g/L
    public double hematocrit { get; set; } // L/L
    public double MCV { get; set; } // fL
    public double MCH { get; set; } // pg
    public double MCHC { get; set; } // g/L
    public double platelets { get; set; }  //x10na9/L   //trombociti
    public double AST { get; set; } // U/L
    public double ALT { get; set; } // U/L
    public double alkaline_phosphatase { get; set; } // U/L
    public double gama_GT { get; set; } // U/L
    public double glucose { get; set; } // mmol/L
    public double bilirubin { get; set; } // µmol/L
    public double total_protein { get; set; } // g/L
    public double albumin { get; set; } // g/L
    public double CRP { get; set; } // mg/L
    public double iron { get; set; } // µmol/L
    public double TIBC { get; set; } // µmol/L
    public int transferiin_saturation { get; set; } // %
    public double feritin { get; set; } // µg/L
    public double cholesterol { get; set; }  // mmol/L
    public double triglycerides { get; set; } // mmol/L
    public double HDL_cholesterol { get; set; } // mmol/L
    public double LDL_cholesterol { get; set; } // mmol/L
    public double CK { get; set; } // U/L
    public double CKMB { get; set; } // U/L
    public double troponin { get; set; } // µg/L
    public double LDH { get; set; } // U/L
    public double parathormon { get; set; } // pg/mL
    public double PV_L { get; set; } // L
    public double PV_INR { get; set; } // INR
    public double APTV { get; set; } // L
    public double fibrinogen { get; set; } // g/L
    public double folic_acid { get; set; } // nmol/L
    public double b12_vitamin { get; set; } // pmol/L
    public int HbA1C { get; set; } // %
    public double residual_diuresis { get; set; } // ml/24 hours
    
    //OVDJE IDU DUPLE VRIJEDNOSTI

    public List<double> urea { get; set; } 
    public List<double> creatinine { get; set; }
    public List<double> urate { get; set; }
    public List<double> sodium { get; set; }
    public List<double> potassium { get; set; }
    public List<double> calcium { get; set; }
    public List<double> phosphorus { get; set; }
    public List<double> kt_V { get; set; }

    
}