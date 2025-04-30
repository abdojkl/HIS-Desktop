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
    [AutoGenerateTable(0)]
    [JengaEntity]
    [Alias("Doctors")]
    public class Doctor
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [JengaImage(150, 150)]
        public byte[] Photo { get; set; }

        [JengaIdentifier]
        public string Name { get; set; }

        [JengaOptions("ذكر,أنثى")]
        
       public string Specialization { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; } 
        public DateTime DateJoined { get; set; }

        [JengaTextArea]
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public List<Visit> GetVisits()
        {
            return Kt.Db.Select<Visit>(r => r.DoctorId == this.Id);
        }
        [JengaVirtualColumn("Patients", "", 10)]
        public double GetpatientCount()
        {
            return GetVisits().Select(r=>r.PatientId).Distinct().Count();
        }
        [JengaVirtualColumn("Visits", "", 11)]
        public double GetVisitCount()
        {
            return Kt.Db.Count<Visit>(r => r.DoctorId == this.Id);
        }

    }
}
