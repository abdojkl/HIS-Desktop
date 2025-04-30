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
    public class Dental
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [JengaTextArea]
        [JengaIdentifier]

        /*.........*/

        public int NVisitD { get; set; }
        public string ReseanD { get; set; }
        public DateTime DateD { get; set; } = DateTime.Now;
        public string TSerProvideD { get; set; }
        public string NSerProvideD { get; set; }

        public string APD { get; set; }
        public string CPD { get; set; }
        public string JawDis { get; set; }
        public string Extraction { get; set; }
        public string DentalProsthetist { get; set; }
        public string MedicineD { get; set; }
       
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
