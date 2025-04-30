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
    public class Visit
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [JengaTextArea]
        [JengaIdentifier]
        public string Type_of_service { get; set; }
        public string Reason { get; set; }
        public string Diagnosis { get; set; }
        public string TSerProvide { get; set; }
        public string NSerProvide { get; set; }
        public string Medicine { get; set; }
        public string med_allergy { get; set; }
        public string Med_antecedents { get; set; }
        public string TestSCH { get; set; }
        public string ECG { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;


        /// <delivary>

        public string Referral { get; set; }
        public string type_delivery { get; set; }
        public string Delivery_Complic { get; set; }
        public string Num_of_bouys { get; set; }
        public string Gender_of_bouy { get; set; }
        public string Weight_of_bouy { get; set; }
        public string BRM { get; set; }
        public string Death_Mother { get; set; }
        public string Death_Bouy { get; set; }


        /// </summary>
        /// <referral>
        public string Referral_From { get; set; }
        public string Referral_To { get; set; }
        /// 
        /// <RH_Service>

        public string RH_Service { get; set; }





        [ForeignKey(typeof(Patient),OnDelete ="CASCADE")]
        [JengaLink("Patient", "GetPatientName()")]
        public int PatientId { get; set; }

        [ForeignKey(typeof(Doctor), OnDelete = "CASCADE")]
        [JengaLink("Doctor", "GetDoctorName()")]
        public int DoctorId { get; set; }

        public bool Syc { get; set; } = false;
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
