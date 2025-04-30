using Kimtoo.DbManager;
using ServiceStack.DataAnnotations;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientRecordManagement.Models
{
    [AutoGenerateTable(1)]
    [JengaEntity]
    [Alias("Visits")]
    public class Birth
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [JengaTextArea]
        [JengaIdentifier]

        /*...........*/

        public int NVisit { get; set; }
        public string Resean { get; set; } 
        public DateTime Date { get; set; } = DateTime.Now;
        
         public string TSerProvide { get; set; }
        public string NSerProvide { get; set; }
       
        public string Referral { get; set; }

        public string BType { get; set; }

        public string BComplic { get; set; }

        public int NumBirth { get; set; }
        public string Gender { get; set; }
        public int WeightB { get; set; }
        public string BRM { get; set; }
        public string DeathM { get; set; }
        public string DeathB { get; set; }
        public string Medicine { get; set; }

        /*...........*/





        [ForeignKey(typeof(Patient),OnDelete ="CASCADE")]
        [JengaLink("Patient", "GetPatientName()")]
        public int PatientId { get; set; }

        [ForeignKey(typeof(Doctor), OnDelete = "CASCADE")]
        [JengaLink("Doctor", "GetDoctorName()")]
        public int DoctorId { get; set; }

        public double Weight { get; set; }
        public double Temperature { get; set; }
        public double Systolic { get; set; }
        public double Diastolic { get; set; }

        [JengaTextArea]
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public Doctor GetDoctor()
        {
            return Kt.Db.SingleById<Doctor>(this.DoctorId);
        }
        public string GetDoctorName()
        {
            return GetDoctor().Name;
        }
        public Patient GetPatient()
        {
            return Kt.Db.SingleById<Patient>(this.PatientId);
        }
        public string GetPatientName()
        {
            return GetPatient().Name;
        }

    }
}
