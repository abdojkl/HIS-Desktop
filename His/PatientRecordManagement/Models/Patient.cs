using Kimtoo.DbManager;
using ServiceStack.DataAnnotations;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientRecordManagement.Models
{
    
    [AutoGenerateTable(0)]
    [JengaEntity]
    [Alias("Patients")]
    public class Patient
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }


        [JengaIdentifier]
        public string Name { get; set; }

        [JengaOptions("ذكر,انثى")]
        public string Gender { get; set; }
        public string prelocation { get; set; }
        public string orglocation { get; set; }



        
        [JengaOptions("غير نازح,نازح")]
        public string Displacement { get; set; }
        [JengaOptions("متزوج/ة,ارمل/ة,مطلق/ة,اعزب")]
        public string Status { get; set; }
        [JengaOptions("لا,نعم")]
        public string Disability { get; set; }
        [JengaOptions("A+,A-,B+,B-,AB+,AB-,O+,O-")]
        public string Bloodtype { get; set; }

        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public string B_G_M_W { get; set; }
        public bool Syc { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

 

        public List<Visit> GetVisits()
        {
            return Kt.Db.Select<Visit>(r => r.PatientId == this.Id);
        }
        [JengaVirtualColumn("Visits","",10)]
        public double GetVisitCount()
        {
            return Kt.Db.Count<Visit>(r => r.PatientId == this.Id);
        }

    }
}
