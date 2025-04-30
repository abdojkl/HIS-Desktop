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
    public class Child
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [JengaTextArea]
        [JengaIdentifier]

        /*.........*/
        public int NVisitCH { get; set; }
        public string ReseanCH { get; set; }
        public DateTime DateCH { get; set; } = DateTime.Now;
        public string TSerProvideCH { get; set; }
        public string NSerProvideCH { get; set; }

        public string MainCompCH { get; set; }
        public string MedicalHisCH { get; set; }
        public string AllergicHisCH { get; set; }
        public string TestSCH { get; set; }
       

        public string DiagnosisCH { get; set; }
        public string MedicineCH { get; set; }

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
