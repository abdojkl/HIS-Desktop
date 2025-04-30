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
    public class Chronic
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [JengaTextArea]
        [JengaIdentifier]

        /*.........*/
        public int NVisitDC { get; set; }
        public string ReseanDC { get; set; }
        public DateTime DateDC { get; set; } = DateTime.Now;
        public string TSerProvideDC { get; set; }
        public string NSerProvideDC { get; set; }

        public string MainCompCD { get; set; }
        public string ChestExCD { get; set; }
        public string HeartExCD { get; set; }
        public string AbdomenExCD { get; set; }
        public string TestCD { get; set; }
        public string ECG { get; set; }
        public string DiagnosisCD { get; set; }
        public string MedicineCD { get; set; }
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
