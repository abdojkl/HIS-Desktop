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
    [Alias("Referral")]
    public class Auricle
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [JengaTextArea]
        [JengaIdentifier]

        /*.........*/
        public int NVisitAC { get; set; }
        public string ReseanAC { get; set; }
        public DateTime DateAC { get; set; } = DateTime.Now;
        public string TSerProvideAC { get; set; }
        public string NSerProvideAC { get; set; }

        public string ACompAC { get; set; }
        public string NCompAC { get; set; }
        public string PL { get; set; }
        public string DiagnosisAC { get; set; }
        public string MedicineAC { get; set; }
        

        /*.........*/




        public int DoctorId { get; set; }
        [ForeignKey(typeof(Patient),OnDelete ="CASCADE")]
        [JengaLink("Patient", "GetPatientName()")]
        public int PatientId { get; set; }

        [ForeignKey(typeof(Doctor), OnDelete = "CASCADE")]
        [JengaLink("Doctor", "GetDoctorName()")]
       

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
