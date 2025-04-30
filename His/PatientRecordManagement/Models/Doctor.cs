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
       

        [JengaIdentifier]
        public string Name { get; set; }

       
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        
        public DateTime DateJoined { get; set; }

       
        public string specialty { get; set; }
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
